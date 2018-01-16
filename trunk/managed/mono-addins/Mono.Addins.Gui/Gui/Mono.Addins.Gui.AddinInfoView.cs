
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Addins.Gui
{
	internal partial class AddinInfoView
	{
		private global::Gtk.EventBox ebox;
		private global::Gtk.VBox vbox6;
		private global::Gtk.EventBox boxHeader;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Image imageHeader;
		private global::Gtk.Label labelHeader;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox headerBox;
		private global::Gtk.HBox boxTitle;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label labelName;
		private global::Gtk.Label labelVersion;
		private global::Gtk.ScrolledWindow scrolledwindow;
		private global::Gtk.EventBox ebox2;
		private global::Gtk.VBox vboxDesc;
		private global::Gtk.Label labelDesc;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Button urlButton;
		private global::Gtk.EventBox eboxButs;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Button btnInstall;
		private global::Gtk.Button btnUpdate;
		private global::Gtk.Button btnDisable;
		private global::Gtk.Button btnUninstall;

		protected virtual void Build ()
		{
			Gui.Initialize (this);
			// Widget Mono.Addins.Gui.AddinInfoView
			BinContainer.Attach (this);
			this.Name = "Mono.Addins.Gui.AddinInfoView";
			// Container child Mono.Addins.Gui.AddinInfoView.Gtk.Container+ContainerChild
			this.ebox = new global::Gtk.EventBox ();
			this.ebox.Name = "ebox";
			// Container child ebox.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			// Container child vbox6.Gtk.Box+BoxChild
			this.boxHeader = new global::Gtk.EventBox ();
			this.boxHeader.Name = "boxHeader";
			// Container child boxHeader.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.imageHeader = new global::Gtk.Image ();
			this.imageHeader.Name = "imageHeader";
			this.imageHeader.Pixbuf = IconLoader.LoadIcon (this, "gtk-dialog-warning", global::Gtk.IconSize.Menu);
			this.hbox2.Add (this.imageHeader);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.imageHeader]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelHeader = new global::Gtk.Label ();
			this.labelHeader.WidthRequest = 250;
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Xalign = 0F;
			this.labelHeader.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.labelHeader.Wrap = true;
			this.hbox2.Add (this.labelHeader);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelHeader]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.boxHeader.Add (this.hbox2);
			this.vbox6.Add (this.boxHeader);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.boxHeader]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(12));
			// Container child vbox3.Gtk.Box+BoxChild
			this.headerBox = new global::Gtk.HBox ();
			this.headerBox.Name = "headerBox";
			this.headerBox.Spacing = 6;
			// Container child headerBox.Gtk.Box+BoxChild
			this.boxTitle = new global::Gtk.HBox ();
			this.boxTitle.Name = "boxTitle";
			this.boxTitle.Spacing = 6;
			// Container child boxTitle.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 3;
			// Container child vbox4.Gtk.Box+BoxChild
			this.labelName = new global::Gtk.Label ();
			this.labelName.WidthRequest = 280;
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 0F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString ("<b><big>Some Addin</big></b>");
			this.labelName.UseMarkup = true;
			this.labelName.Wrap = true;
			this.vbox4.Add (this.labelName);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.labelName]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.labelVersion = new global::Gtk.Label ();
			this.labelVersion.WidthRequest = 280;
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Xalign = 0F;
			this.labelVersion.LabelProp = global::Mono.Unix.Catalog.GetString ("Version 2.6");
			this.labelVersion.Wrap = true;
			this.vbox4.Add (this.labelVersion);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.labelVersion]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.boxTitle.Add (this.vbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.boxTitle [this.vbox4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.headerBox.Add (this.boxTitle);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.headerBox [this.boxTitle]));
			w8.Position = 0;
			this.vbox3.Add (this.headerBox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.headerBox]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.scrolledwindow = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow.CanFocus = true;
			this.scrolledwindow.Name = "scrolledwindow";
			this.scrolledwindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			// Container child scrolledwindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w10 = new global::Gtk.Viewport ();
			w10.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.ebox2 = new global::Gtk.EventBox ();
			this.ebox2.Name = "ebox2";
			// Container child ebox2.Gtk.Container+ContainerChild
			this.vboxDesc = new global::Gtk.VBox ();
			this.vboxDesc.Name = "vboxDesc";
			this.vboxDesc.Spacing = 6;
			// Container child vboxDesc.Gtk.Box+BoxChild
			this.labelDesc = new global::Gtk.Label ();
			this.labelDesc.WidthRequest = 250;
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Xalign = 0F;
			this.labelDesc.LabelProp = global::Mono.Unix.Catalog.GetString ("Long description of the extension. Long description of the extension. Long description of the extension. Long description of the extension. Long description of the extension. Long description of the extension. ");
			this.labelDesc.Wrap = true;
			this.vboxDesc.Add (this.labelDesc);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxDesc [this.labelDesc]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxDesc.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.urlButton = new global::Gtk.Button ();
			this.urlButton.CanFocus = true;
			this.urlButton.Name = "urlButton";
			this.urlButton.UseUnderline = true;
			this.urlButton.Relief = ((global::Gtk.ReliefStyle)(2));
			this.urlButton.Label = global::Mono.Unix.Catalog.GetString ("More information");
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("web-search-16.png");
			this.urlButton.Image = w12;
			this.hbox3.Add (this.urlButton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.urlButton]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			this.vboxDesc.Add (this.hbox3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxDesc [this.hbox3]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.ebox2.Add (this.vboxDesc);
			w10.Add (this.ebox2);
			this.scrolledwindow.Add (w10);
			this.vbox3.Add (this.scrolledwindow);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.scrolledwindow]));
			w18.Position = 1;
			this.vbox6.Add (this.vbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox3]));
			w19.Position = 1;
			// Container child vbox6.Gtk.Box+BoxChild
			this.eboxButs = new global::Gtk.EventBox ();
			this.eboxButs.Name = "eboxButs";
			// Container child eboxButs.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnInstall = new global::Gtk.Button ();
			this.btnInstall.CanFocus = true;
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.UseUnderline = true;
			this.btnInstall.Label = global::Mono.Unix.Catalog.GetString ("Install...");
			global::Gtk.Image w20 = new global::Gtk.Image ();
			w20.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("download-16.png");
			this.btnInstall.Image = w20;
			this.hbox1.Add (this.btnInstall);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnInstall]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnUpdate = new global::Gtk.Button ();
			this.btnUpdate.CanFocus = true;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseUnderline = true;
			this.btnUpdate.Label = global::Mono.Unix.Catalog.GetString ("Update");
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("download-16.png");
			this.btnUpdate.Image = w22;
			this.hbox1.Add (this.btnUpdate);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnUpdate]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnDisable = new global::Gtk.Button ();
			this.btnDisable.CanFocus = true;
			this.btnDisable.Name = "btnDisable";
			this.btnDisable.UseUnderline = true;
			this.btnDisable.Label = global::Mono.Unix.Catalog.GetString ("Disable");
			this.hbox1.Add (this.btnDisable);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnDisable]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnUninstall = new global::Gtk.Button ();
			this.btnUninstall.CanFocus = true;
			this.btnUninstall.Name = "btnUninstall";
			this.btnUninstall.UseUnderline = true;
			this.btnUninstall.Label = global::Mono.Unix.Catalog.GetString ("_Uninstall...");
			this.hbox1.Add (this.btnUninstall);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnUninstall]));
			w25.Position = 3;
			w25.Expand = false;
			w25.Fill = false;
			this.eboxButs.Add (this.hbox1);
			this.vbox6.Add (this.eboxButs);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.eboxButs]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.ebox.Add (this.vbox6);
			this.Add (this.ebox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.urlButton.Clicked += new global::System.EventHandler (this.OnUrlButtonClicked);
			this.btnInstall.Clicked += new global::System.EventHandler (this.OnBtnInstallClicked);
			this.btnUpdate.Clicked += new global::System.EventHandler (this.OnBtnUpdateClicked);
			this.btnDisable.Clicked += new global::System.EventHandler (this.OnBtnDisableClicked);
			this.btnUninstall.Clicked += new global::System.EventHandler (this.OnBtnUninstallClicked);
		}
	}
}
