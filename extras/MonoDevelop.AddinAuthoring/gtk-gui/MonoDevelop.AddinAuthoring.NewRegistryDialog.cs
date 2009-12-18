// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.AddinAuthoring {
    
    
    public partial class NewRegistryDialog {
        
        private Gtk.Table table1;
        
        private Gtk.Entry entryName;
        
        private MonoDevelop.Components.FolderEntry entryRegPath;
        
        private Gtk.Label label1;
        
        private Gtk.Label label2;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.AddinAuthoring.NewRegistryDialog
            this.Name = "MonoDevelop.AddinAuthoring.NewRegistryDialog";
            this.Title = Mono.Addins.AddinManager.CurrentLocalizer.GetString("New Registry");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.DefaultWidth = 0;
            this.DefaultHeight = 0;
            // Internal child MonoDevelop.AddinAuthoring.NewRegistryDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            this.table1.BorderWidth = ((uint)(9));
            // Container child table1.Gtk.Table+TableChild
            this.entryName = new Gtk.Entry();
            this.entryName.CanFocus = true;
            this.entryName.Name = "entryName";
            this.entryName.IsEditable = true;
            this.entryName.InvisibleChar = '●';
            this.table1.Add(this.entryName);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.entryName]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.entryRegPath = new MonoDevelop.Components.FolderEntry();
            this.entryRegPath.Name = "entryRegPath";
            this.table1.Add(this.entryRegPath);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.entryRegPath]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Application Name:");
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Registry Path:");
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            w1.Add(this.table1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(w1[this.table1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Internal child MonoDevelop.AddinAuthoring.NewRegistryDialog.ActionArea
            Gtk.HButtonBox w7 = this.ActionArea;
            w7.Name = "dialog1_ActionArea";
            w7.Spacing = 6;
            w7.BorderWidth = ((uint)(5));
            w7.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.buttonCancel]));
            w8.Expand = false;
            w8.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.buttonOk]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}