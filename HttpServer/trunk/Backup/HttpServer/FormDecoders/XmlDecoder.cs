using System.IO;
using System.Text;
using System.Xml;
using HttpServer.FormDecoders;

namespace HttpServer.FormDecoders
{
    /// <summary>
    /// This decoder converts XML documents to form items.
    /// Each element becomes a subitem in the form, and each attribute becomes an item.
    /// </summary>
    /// <example>
    /// // xml: <hello id="1">something<world id="2">data</world></hello>
    /// // result: 
    /// // form["hello"].Value = "something"
    /// // form["hello"]["id"].Value = 1
    /// // form["hello"]["world]["id"].Value = 1
    /// // form["hello"]["world"].Value = "data"
    /// </example>
    /// <remarks>
    /// The original xml document is stored in form["__xml__"].Value.
    /// </remarks>
    public class XmlDecoder : FormDecoder
    {
        #region FormDecoder Members

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream">Stream containing the content</param>
        /// <param name="contentType">Content type (with any additional info like boundry). Content type is always supplied in lower case</param>
        /// <param name="encoding">Stream encoding</param>
        /// Note: contentType and encoding are not used?
        /// <returns>A http form, or null if content could not be parsed.</returns>
        /// <exception cref="InvalidDataException"></exception>
        public HttpInput Decode(Stream stream, string contentType, Encoding encoding)
        {
            if (stream == null || stream.Length == 0)
                return null;
            if (!CanParse(contentType))
                return null;
            if (encoding == null)
                encoding = Encoding.UTF8;

            HttpInput form = new HttpInput("xml");

            using (TextReader reader = new StreamReader(stream))
            {
                // let's start with saving the raw xml
                form.Add("__xml__", reader.ReadToEnd());

                try
                {
                    // Now let's process the data.
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(form["__xml__"].Value);
                    XmlNode child = doc.FirstChild;
                    // Skip to next node if the node is an XML Declaration 
                    if (child.NodeType == XmlNodeType.XmlDeclaration)
                        child = child.NextSibling;
                    TraverseNode(form, child);
                }
                catch (XmlException err)
                {
                    throw new InvalidDataException("Failed to traverse XML", err);
                }
 ;           }

            return form;
        }

        /// <summary>
        /// Recursive function that will go through an xml element and store it's content 
        /// to the form item.
        /// </summary>
        /// <param name="item">(parent) Item in form that content should be added to.</param>
        /// <param name="node">Node that should be parsed.</param>
        public void TraverseNode(HttpInputBase item, XmlNode node)
        {
            // Add text node content to previous item
            if (node.Name == "#text")
            {
                HttpInputItem formItem = item as HttpInputItem;
                if (formItem != null)
                {
                    formItem.Add(node.InnerText.Trim());
                    return;
                }
            }

            string name = node.Name.ToLower();
            item.Add(name, node.Value);
            HttpInputBase myItem = item[name];

            if (node.Attributes != null)
                foreach (XmlAttribute attribute in node.Attributes)
                    myItem.Add(attribute.Name.ToLower(), attribute.Value);

            if (node.ChildNodes != null)
                foreach (XmlNode childNode in node.ChildNodes)
                    TraverseNode(myItem, childNode);
        }

        /// <summary>
        /// Checks if the decoder can handle the mime type
        /// </summary>
        /// <param name="contentType">Content type (with any additional info like boundry). Content type is always supplied in lower case.</param>
        /// <returns>True if the decoder can parse the specified content type</returns>
        public bool CanParse(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return false;

            return contentType.Contains("text/xml");
        }

        #endregion
    }
}