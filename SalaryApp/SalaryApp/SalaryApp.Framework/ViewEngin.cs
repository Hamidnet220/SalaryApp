using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.Framework.IOC;

namespace SalaryApp.Framework
{
    public class ViewEngin
    {
        private TabControl tabControl;
        private Dictionary<string, TabPage> openTabs = new Dictionary<string, TabPage>();
        private Dictionary<string,Form> openForms=new Dictionary<string, Form>();


        public ViewEngin(TabControl tabControl)
        {
            this.tabControl = tabControl;
        }
        public ViewBase ViewInTab<T>(Action<T> initializer=null) where T : ViewBase
        {
            var typeRegistery = new TypeRegistery();
            var container = new StructureMap.Container(typeRegistery);
            var viewInstance = container.GetInstance<T>();
            if (initializer !=null)
                initializer(viewInstance);
            viewInstance.ViewEngin = this;
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
            openTabs.Add(viewInstance.ViewIdentifier, tabPage);
            return (T)viewInstance;
        }

        public T ViewInForm<T>(Action<T> initialazer=null, bool displayAsDialog=false
            , FormWindowState windowState = FormWindowState.Normal,bool topButtonBar=false) where T : ViewBase
        {

            var typeRegistery = new TypeRegistery();
            var container = new StructureMap.Container(typeRegistery);
            var viewInstance = container.GetInstance<T>();
            viewInstance.ViewEngin = this;
            if (initialazer != null)
                initialazer(viewInstance);

            if (openForms.ContainsKey(viewInstance.ViewIdentifier))
            {
                var currentForm = openForms[viewInstance.ViewIdentifier];
                currentForm.Activate();
                return (T)currentForm.Controls.OfType<ViewBase>().First();
            }
            
            viewInstance.VisibleTopBar = topButtonBar;

            var form = new Form();
            form.Height = 600;
            form.Width = 800;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.RightToLeft = RightToLeft.Yes;
            form.Font = new Font("Tahoma", 8);
            form.Text = viewInstance.ViewTitle;
            viewInstance.Dock = DockStyle.Fill;
            form.Controls.Add(viewInstance);
            form.FormClosed += (obj, e) =>
            {
                openForms.Remove(viewInstance.ViewIdentifier);
            };
                
            form.WindowState = windowState;
            openForms.Add(viewInstance.ViewIdentifier,form);
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

        public void CloseView(ViewBase viewBase,DialogResult? dialogResult=null)
        {
            if (openForms.ContainsKey(viewBase.ViewIdentifier))
            {
                if (dialogResult.HasValue)
                {
                    openForms[viewBase.ViewIdentifier].DialogResult = dialogResult.Value;
                    viewBase.DialogResult = dialogResult.Value;
                    if (!openForms[viewBase.ViewIdentifier].Modal)
                    {
                        openForms[viewBase.ViewIdentifier].Close();
                    }
                }
                else
                    openForms[viewBase.ViewIdentifier].Close();

                openForms.Remove(viewBase.ViewIdentifier);
            }
            else if(openTabs.ContainsKey((viewBase.ViewIdentifier)))
            {
                tabControl.TabPages.Remove(openTabs[viewBase.ViewIdentifier]);
                openTabs.Remove(viewBase.ViewIdentifier);
            }
        }
    }
}
