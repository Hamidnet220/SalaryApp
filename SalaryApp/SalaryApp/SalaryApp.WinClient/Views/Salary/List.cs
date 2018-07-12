using System;
using System.Linq;
using System.Windows.Forms;
using SalarApp.Framework;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;

namespace SalaryApp.WinClient.Views.Salary
{
    public partial class List : ViewBase
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());
        private GridControl<Repositoris.Entities.Salary> grid;

        public List()
        {
            InitializeComponent();
            this.ViewTitle = @"لیست حقوق ها";

            AddAction("ریز حقوق",btn =>
            {
                ViewEngin.ViewInForm<Views.SalaryDetails.List>(null,true,FormWindowState.Maximized,true);
            });

            AddAction("فایل پرداخت", btn =>
            {

            });

            AddAction("فایل های بیمه", btn =>
            {

            });

            AddAction("فایل های مالیات", btn =>
            {

            });

            AddAction("فیش های حقوقی", btn =>
            {

            });

            AddAction("قفل کردن ماه", btn =>
            {

            });
        }

        protected override void OnLoad(EventArgs e)
        {
            var salaryList = unitOfWork.Salaries.GetAll().ToList();
            grid = new GridControl<Repositoris.Entities.Salary>(this);

            grid.AddTextBoxColumn("عنوان لیست", s => s.Title);
            grid.AddTextBoxColumn("سال", s => s.Year);
            grid.AddTextBoxColumn("ماه", s => s.Month);
            grid.AddTextBoxColumn("تعداد پرسنل", s => s.EmployeesCount);
            grid.AddTextBoxColumn("وضعیت", s => s.IsLocked);
            grid.SetDataSource(salaryList);
            base.OnLoad(e);
        }

       
    }
}
