using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalaryApp.Framework
{
    public partial class MainForm : Form
    {
        private MenuHandler menuHandler;
        private ViewEngin viewEngin;
        public MainForm()
        {
            InitializeComponent();
            WindowState=FormWindowState.Maximized;
            menuHandler=new MenuHandler(MainMenuStrip.Items);
            var toolstripLabel=new ToolStripLabel();
            DateTimeTimer.Tick += (obj, e) =>
            {
                toolstripLabel.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss");
            };

            DateTimeTimer.Interval = 1000;
            StatusBarStrip.Items.Add(toolstripLabel);
            DateTimeTimer.Start();

        }

        protected MenuHandler AddMenu(string title )
        {
            return menuHandler.AddMenu(title, null, null);
        }

        protected MenuHandler AddMenu(string title, Image image)
        {
            return menuHandler.AddMenu(title, image, null);
        }

        protected MenuHandler AddMenu(string title, Image image, EventHandler eventHandler)
        {
            return menuHandler.AddMenu(title, image, eventHandler);
        }

        public ViewEngin ViewEngin
        {
            get
            {
                if(viewEngin==null)
                 viewEngin=new ViewEngin(tabControl1);
                return viewEngin;
            }
        }

        private void CloseCurrentTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewEngin.CloseViewTab(tabControl1.SelectedTab);
        }
    }
}
