using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalaryApp.Framework
{
    public class MenuHandler
    {
        private ToolStripItemCollection items;

        public MenuHandler(ToolStripItemCollection items)
        {
            this.items = items;
        }

        public MenuHandler AddMenu(string title)
        {
            var menu= (ToolStripMenuItem)items.Add(title, null, null);
            return new MenuHandler(menu.DropDownItems); 
        }

        public MenuHandler AddMenu(string title,Image image)
        {
            var menu= (ToolStripMenuItem)items.Add(title, image, null);
            return new MenuHandler(menu.DropDownItems); 
        }

        public MenuHandler AddMenu(string title,Image image,EventHandler eventHandler)
        {
            var menu= (ToolStripMenuItem)items.Add(title, image, eventHandler);
            return new MenuHandler(menu.DropDownItems); 
        }

        public void AddSeparator()
        {
            items.Add("-");
        }
    }
}