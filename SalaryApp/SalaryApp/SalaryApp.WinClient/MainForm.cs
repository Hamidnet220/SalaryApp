using System.Windows.Forms;

namespace SalaryApp.WinClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.RightToLeft=RightToLeft.Yes;
            this.WindowState=FormWindowState.Maximized;
            this.Text = @"برنامه حقوق و دستمزد شرکت یاور پویای جنوب";

            var baseInfoItem =(ToolStripMenuItem) MainMenuStrip.Items.Add("اطلاعات پایه",null,null);
                baseInfoItem.DropDownItems.Add("اطلاعات کارکنان", null, (obj, e) =>
                {
                    var view = new Views.Employees.EmployeeList();
                    view.ShowDialog();
                });
                baseInfoItem.DropDownItems.Add("اطلاعات شرکت ها", null, null);
                baseInfoItem.DropDownItems.Add("خروج", null, (obj, e) => { Application.Exit();});

        }
    }
}
