using System.Windows.Forms;
using SalaryApp.WinClient.Views.Companies;

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


            //base info menu
            var baseInfoItem =(ToolStripMenuItem) MainMenuStrip.Items.Add("اطلاعات پایه",null,null);

            baseInfoItem.DropDownItems.Add("اطلاعات شرکت ها", null, (obj, e) =>
            {
                var view=new Views.Companies.CompaniesList();
                view.ShowDialog();
            });

            baseInfoItem.DropDownItems.Add("اطلاعات کارگاه ها", null, (obj, e) =>
            {
                var view = new Views.Workplace.WorkplaceList();
                view.ShowDialog();
            });

            baseInfoItem.DropDownItems.Add("اطلاعات کارکنان", null, (obj, e) =>
                {
                    var view = new Views.Employees.EmployeeList();
                    view.ShowDialog();
                });


            baseInfoItem.DropDownItems.Add("خروج", null, (obj, e) => { Application.Exit();});


            //salary menu
            var salaryMenu =(ToolStripMenuItem) MainMenuStrip.Items.Add("حقوق و دستمزد", null);

            salaryMenu.DropDownItems.Add("ایجاد ماه جدید", null, null);

            
            //report Menu
            var reportMenu = (ToolStripMenuItem) MainMenuStrip.Items.Add("گزارشات", null);

            reportMenu.DropDownItems.Add("بیمه", null, null);
            reportMenu.DropDownItems.Add("مالیات", null, null);
            reportMenu.DropDownItems.Add("مساعده", null, null);
            reportMenu.DropDownItems.Add("حضور و غیاب", null, null);
            reportMenu.DropDownItems.Add("لیست حقوق", null, null);
            reportMenu.DropDownItems.Add("لیست بانک", null, null);
            reportMenu.DropDownItems.Add("پاداش بهره وری", null, null);



        }
    }
}
