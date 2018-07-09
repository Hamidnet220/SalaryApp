using System.Windows.Forms;
using SalaryApp.WinClient.Views.Companies;

namespace SalaryApp.WinClient
{
    public partial class MainForm : Framework.MainForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = @"برنامه حقوق و دستمزد شرکت یاور پویای جنوب";


            //base info menu
            var baseInfoItem = AddMenu("اطلاعات پایه", null, null);

            baseInfoItem.AddMenu("اطلاعات شرکت ها", null, (obj, e) =>
            {
                ViewEngin.ViewInForm<Views.Companies.List>(null,true);
            });

            baseInfoItem.AddMenu("اطلاعات کارگاه ها", null, (obj, e) =>
            {
                ViewEngin.ViewInForm<Views.Workplace.List>();
            });

            baseInfoItem.AddMenu("اطلاعات کارکنان", null, (obj, e) =>
            {
                ViewEngin.ViewInTab<Views.Employees.List>();
            });

            baseInfoItem.AddSeparator();

            baseInfoItem.AddMenu("خروج", null, (obj, e) => { Application.Exit(); });


            //salary menu
            var salaryMenu = AddMenu("حقوق و دستمزد", null);

            salaryMenu.AddMenu("لیست های حقوق", null, (obj, e) =>
            {
                var view = new Views.Salary.List();
            });


            //report Menu
            var reportMenu = AddMenu("گزارشات", null);
            reportMenu.AddMenu("بیمه", null, null);
            reportMenu.AddMenu("مالیات", null, null);
            reportMenu.AddSeparator();
            reportMenu.AddMenu("مساعده", null, null);
            reportMenu.AddMenu("حضور و غیاب", null, null);
            reportMenu.AddMenu("لیست حقوق", null, null);
            reportMenu.AddSeparator();
            reportMenu.AddMenu("لیست بانک", null, null);
            reportMenu.AddMenu("پاداش بهره وری", null, null);



        }
    }
}
