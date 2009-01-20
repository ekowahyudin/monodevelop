// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Core.Gui.Dialogs {
    
    
    internal partial class MultiTaskProgressDialog {
        
        private Gtk.Label title;
        
        private Gtk.ScrolledWindow progressScroll;
        
        private Gtk.TreeView progressTreeView;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow detailsScroll;
        
        private Gtk.TextView detailsTextView;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonClose;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Core.Gui.Dialogs.MultiTaskProgressDialog
            this.Name = "MonoDevelop.Core.Gui.Dialogs.MultiTaskProgressDialog";
            this.Title = Mono.Unix.Catalog.GetString("Progress");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.HasSeparator = false;
            // Internal child MonoDevelop.Core.Gui.Dialogs.MultiTaskProgressDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.title = new Gtk.Label();
            this.title.Name = "title";
            this.title.Xalign = 0F;
            this.title.UseMarkup = true;
            w1.Add(this.title);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(w1[this.title]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.progressScroll = new Gtk.ScrolledWindow();
            this.progressScroll.WidthRequest = 400;
            this.progressScroll.HeightRequest = 150;
            this.progressScroll.CanFocus = true;
            this.progressScroll.Name = "progressScroll";
            this.progressScroll.HscrollbarPolicy = ((Gtk.PolicyType)(2));
            this.progressScroll.ShadowType = ((Gtk.ShadowType)(1));
            // Container child progressScroll.Gtk.Container+ContainerChild
            this.progressTreeView = new Gtk.TreeView();
            this.progressTreeView.CanFocus = true;
            this.progressTreeView.Name = "progressTreeView";
            this.progressScroll.Add(this.progressTreeView);
            w1.Add(this.progressScroll);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.progressScroll]));
            w4.Position = 1;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Details:");
            w1.Add(this.label1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(w1[this.label1]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            w5.Padding = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.detailsScroll = new Gtk.ScrolledWindow();
            this.detailsScroll.HeightRequest = 120;
            this.detailsScroll.CanFocus = true;
            this.detailsScroll.Name = "detailsScroll";
            this.detailsScroll.HscrollbarPolicy = ((Gtk.PolicyType)(2));
            this.detailsScroll.ShadowType = ((Gtk.ShadowType)(1));
            // Container child detailsScroll.Gtk.Container+ContainerChild
            this.detailsTextView = new Gtk.TextView();
            this.detailsTextView.CanFocus = true;
            this.detailsTextView.Name = "detailsTextView";
            this.detailsTextView.Editable = false;
            this.detailsTextView.CursorVisible = false;
            this.detailsTextView.WrapMode = ((Gtk.WrapMode)(3));
            this.detailsScroll.Add(this.detailsTextView);
            w1.Add(this.detailsScroll);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(w1[this.detailsScroll]));
            w7.Position = 3;
            // Internal child MonoDevelop.Core.Gui.Dialogs.MultiTaskProgressDialog.ActionArea
            Gtk.HButtonBox w8 = this.ActionArea;
            w8.Name = "dialog1_ActionArea";
            w8.Spacing = 6;
            w8.BorderWidth = ((uint)(5));
            w8.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonCancel]));
            w9.Expand = false;
            w9.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonClose = new Gtk.Button();
            this.buttonClose.CanDefault = true;
            this.buttonClose.CanFocus = true;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseStock = true;
            this.buttonClose.UseUnderline = true;
            this.buttonClose.Label = "gtk-close";
            this.AddActionWidget(this.buttonClose, -7);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonClose]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 491;
            this.DefaultHeight = 418;
            this.title.Hide();
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.DeleteActivated);
            this.buttonCancel.Clicked += new System.EventHandler(this.OnCancel);
            this.buttonClose.Clicked += new System.EventHandler(this.OnClose);
        }
    }
}
