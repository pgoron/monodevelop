// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Projects.Gui.Dialogs.OptionPanels {
    
    internal partial class CombineEntryConfigurationsPanelWidget {
        
        private Gtk.VBox vbox75;
        
        private Gtk.HBox hbox61;
        
        private Gtk.ScrolledWindow scrolledwindow12;
        
        private Gtk.TreeView configsList;
        
        private Gtk.VBox vbox76;
        
        private Gtk.Button addButton;
        
        private Gtk.Button copyButton;
        
        private Gtk.Button removeButton;
        
        private Gtk.Button renameButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Projects.Gui.Dialogs.OptionPanels.CombineEntryConfigurationsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Projects.Gui.Dialogs.OptionPanels.CombineEntryConfigurationsPanelWidget";
            // Container child MonoDevelop.Projects.Gui.Dialogs.OptionPanels.CombineEntryConfigurationsPanelWidget.Gtk.Container+ContainerChild
            this.vbox75 = new Gtk.VBox();
            this.vbox75.Name = "vbox75";
            // Container child vbox75.Gtk.Box+BoxChild
            this.hbox61 = new Gtk.HBox();
            this.hbox61.Name = "hbox61";
            this.hbox61.Spacing = 6;
            // Container child hbox61.Gtk.Box+BoxChild
            this.scrolledwindow12 = new Gtk.ScrolledWindow();
            this.scrolledwindow12.Name = "scrolledwindow12";
            this.scrolledwindow12.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow12.Gtk.Container+ContainerChild
            this.configsList = new Gtk.TreeView();
            this.configsList.Name = "configsList";
            this.scrolledwindow12.Add(this.configsList);
            this.hbox61.Add(this.scrolledwindow12);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox61[this.scrolledwindow12]));
            w2.Position = 0;
            // Container child hbox61.Gtk.Box+BoxChild
            this.vbox76 = new Gtk.VBox();
            this.vbox76.Name = "vbox76";
            this.vbox76.Spacing = 6;
            // Container child vbox76.Gtk.Box+BoxChild
            this.addButton = new Gtk.Button();
            this.addButton.Name = "addButton";
            this.addButton.UseStock = true;
            this.addButton.UseUnderline = true;
            this.addButton.Label = "gtk-add";
            this.vbox76.Add(this.addButton);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox76[this.addButton]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox76.Gtk.Box+BoxChild
            this.copyButton = new Gtk.Button();
            this.copyButton.Name = "copyButton";
            this.copyButton.UseStock = true;
            this.copyButton.UseUnderline = true;
            this.copyButton.Label = "gtk-copy";
            this.vbox76.Add(this.copyButton);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox76[this.copyButton]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox76.Gtk.Box+BoxChild
            this.removeButton = new Gtk.Button();
            this.removeButton.Name = "removeButton";
            this.removeButton.UseStock = true;
            this.removeButton.UseUnderline = true;
            this.removeButton.Label = "gtk-remove";
            this.vbox76.Add(this.removeButton);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox76[this.removeButton]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox76.Gtk.Box+BoxChild
            this.renameButton = new Gtk.Button();
            this.renameButton.Name = "renameButton";
            this.renameButton.UseUnderline = true;
            this.renameButton.Label = MonoDevelop.Core.GettextCatalog.GetString("Rename");
            this.vbox76.Add(this.renameButton);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox76[this.renameButton]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            this.hbox61.Add(this.vbox76);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox61[this.vbox76]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox75.Add(this.hbox61);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox75[this.hbox61]));
            w8.Position = 0;
            this.Add(this.vbox75);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}