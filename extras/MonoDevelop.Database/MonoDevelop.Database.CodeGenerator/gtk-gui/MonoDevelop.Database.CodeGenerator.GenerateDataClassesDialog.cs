// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Database.CodeGenerator {
    
    
    public partial class GenerateDataClassesDialog {
        
        private Gtk.Notebook notebook;
        
        private Gtk.Table tableGeneral;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Table tableTables;
        
        private Gtk.Label label10;
        
        private Gtk.Label label9;
        
        private Gtk.Label label8;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.CodeGenerator.GenerateDataClassesDialog
            this.Name = "MonoDevelop.Database.CodeGenerator.GenerateDataClassesDialog";
            this.Title = AddinCatalog.GetString("Generate Data Classes");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child MonoDevelop.Database.CodeGenerator.GenerateDataClassesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.notebook = new Gtk.Notebook();
            this.notebook.CanFocus = true;
            this.notebook.Name = "notebook";
            this.notebook.CurrentPage = 1;
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.tableGeneral = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.tableGeneral.Name = "tableGeneral";
            this.tableGeneral.RowSpacing = ((uint)(6));
            this.tableGeneral.ColumnSpacing = ((uint)(6));
            // Container child tableGeneral.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = AddinCatalog.GetString("Location:");
            this.tableGeneral.Add(this.label5);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.tableGeneral[this.label5]));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableGeneral.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = AddinCatalog.GetString("Database:");
            this.tableGeneral.Add(this.label6);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.tableGeneral[this.label6]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            this.notebook.Add(this.tableGeneral);
            // Notebook tab
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = AddinCatalog.GetString("General");
            this.notebook.SetTabLabel(this.tableGeneral, this.label7);
            this.label7.ShowAll();
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.tableTables = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.tableTables.Name = "tableTables";
            this.tableTables.RowSpacing = ((uint)(6));
            this.tableTables.ColumnSpacing = ((uint)(6));
            // Container child tableTables.Gtk.Table+TableChild
            this.label10 = new Gtk.Label();
            this.label10.Name = "label10";
            this.label10.LabelProp = AddinCatalog.GetString("Fields & Properties");
            this.tableTables.Add(this.label10);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.tableTables[this.label10]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableTables.Gtk.Table+TableChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.LabelProp = AddinCatalog.GetString("Classes");
            this.tableTables.Add(this.label9);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.tableTables[this.label9]));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            this.notebook.Add(this.tableTables);
            Gtk.Notebook.NotebookChild w7 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.tableTables]));
            w7.Position = 1;
            // Notebook tab
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.LabelProp = AddinCatalog.GetString("Tables");
            this.notebook.SetTabLabel(this.tableTables, this.label8);
            this.label8.ShowAll();
            w1.Add(this.notebook);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.notebook]));
            w8.Position = 0;
            // Internal child MonoDevelop.Database.CodeGenerator.GenerateDataClassesDialog.ActionArea
            Gtk.HButtonBox w9 = this.ActionArea;
            w9.Name = "dialog1_ActionArea";
            w9.Spacing = 6;
            w9.BorderWidth = ((uint)(5));
            w9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonCancel]));
            w10.Expand = false;
            w10.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonOk]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 699;
            this.DefaultHeight = 471;
            this.Show();
        }
    }
}