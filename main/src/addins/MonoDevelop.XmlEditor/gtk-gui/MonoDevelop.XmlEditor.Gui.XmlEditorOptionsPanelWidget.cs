// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.XmlEditor.Gui {
    
    public partial class XmlEditorOptionsPanelWidget {
        
        private Gtk.VBox vbox1;
        
        private Gtk.CheckButton autoCompleteElementsCheck;
        
        private Gtk.CheckButton showSchemaAnnotationCheck;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.XmlEditor.Gui.XmlEditorOptionsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.XmlEditor.Gui.XmlEditorOptionsPanelWidget";
            // Container child MonoDevelop.XmlEditor.Gui.XmlEditorOptionsPanelWidget.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.autoCompleteElementsCheck = new Gtk.CheckButton();
            this.autoCompleteElementsCheck.CanFocus = true;
            this.autoCompleteElementsCheck.Name = "autoCompleteElementsCheck";
            this.autoCompleteElementsCheck.Label = Mono.Unix.Catalog.GetString("Autocomplete XML closing tags");
            this.autoCompleteElementsCheck.DrawIndicator = true;
            this.autoCompleteElementsCheck.UseUnderline = true;
            this.vbox1.Add(this.autoCompleteElementsCheck);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.autoCompleteElementsCheck]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.showSchemaAnnotationCheck = new Gtk.CheckButton();
            this.showSchemaAnnotationCheck.Sensitive = false;
            this.showSchemaAnnotationCheck.CanFocus = true;
            this.showSchemaAnnotationCheck.Name = "showSchemaAnnotationCheck";
            this.showSchemaAnnotationCheck.Label = Mono.Unix.Catalog.GetString("Show schema annotation");
            this.showSchemaAnnotationCheck.DrawIndicator = true;
            this.showSchemaAnnotationCheck.UseUnderline = true;
            this.vbox1.Add(this.showSchemaAnnotationCheck);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.showSchemaAnnotationCheck]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}