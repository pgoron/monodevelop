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
    
    
    public partial class TypeSelector {
        
        private Gtk.HBox hbox3;
        
        private Gtk.EventBox eventbox;
        
        private Gtk.Image typeImage;
        
        private Gtk.ComboBoxEntry combo;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.AddinAuthoring.TypeSelector
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.AddinAuthoring.TypeSelector";
            // Container child MonoDevelop.AddinAuthoring.TypeSelector.Gtk.Container+ContainerChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.eventbox = new Gtk.EventBox();
            this.eventbox.Name = "eventbox";
            // Container child eventbox.Gtk.Container+ContainerChild
            this.typeImage = new Gtk.Image();
            this.typeImage.Name = "typeImage";
            this.typeImage.Pixbuf = Stetic.IconLoader.LoadIcon(this, "md-addinauthoring-newclass", Gtk.IconSize.Menu, 16);
            this.eventbox.Add(this.typeImage);
            this.hbox3.Add(this.eventbox);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox3[this.eventbox]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.combo = Gtk.ComboBoxEntry.NewText();
            this.combo.Name = "combo";
            this.hbox3.Add(this.combo);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox3[this.combo]));
            w3.Position = 1;
            this.Add(this.hbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.combo.Changed += new System.EventHandler(this.OnComboChanged);
        }
    }
}