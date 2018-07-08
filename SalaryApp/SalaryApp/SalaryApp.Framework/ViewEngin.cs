using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryApp.Framework
{
    public class ViewEngin
    {
        private TabControl tabControl;
        private Dictionary<string, TabPage> openTabs = new Dictionary<string, TabPage>();

        public ViewEngin(TabControl tabControl)
        {
            this.tabControl = tabControl;
        }
        public ViewBase ViewInTab<T>() where T : ViewBase
        {
            var viewInstance = (ViewBase)Activator.CreateInstance<T>();
            if (openTabs.ContainsKey(viewInstance.ViewIdentifier))
            {
                var currentTab = openTabs[viewInstance.ViewIdentifier];
                tabControl.SelectedTab = currentTab;
                return currentTab.Controls.OfType<T>().First();
            }
            TabPage tabPage = new TabPage();
            tabPage.Text = viewInstance.ViewTitle;
            tabPage.Controls.Add(viewInstance);
            viewInstance.Dock = DockStyle.Fill;
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;
            openTabs.Add(viewInstance.ViewIdentifier,tabPage);
            return (T)viewInstance;
        }

        public T ViewInForm<T>(bool displayAsDialog) where T : ViewBase
        {
            var viewInstance = (ViewBase)Activator.CreateInstance<T>();
            var form = new Form();
            form.Height = 800;
            form.Width = 600;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.RightToLeft = RightToLeft.Yes;
            form.Font = new Font("Tahoma", 8);
            form.Text = viewInstance.ViewTitle;
            viewInstance.Dock = DockStyle.Fill;
            form.Controls.Add(viewInstance);
            if (displayAsDialog)
                form.ShowDialog();
            else
                form.Show();
            return (T)viewInstance;
        }

        public void CloseViewTab(TabPage selectedTab)
        {
            var currentView = selectedTab.Controls.OfType<ViewBase>().FirstOrDefault();
            if (currentView != null)
            {
                var viewIdentifire = currentView.ViewIdentifier;
                if (openTabs.ContainsKey(viewIdentifire))
                {
                    openTabs.Remove(viewIdentifire);
                }

                tabControl.TabPages.Remove(selectedTab);
            }
        }
    }
}
