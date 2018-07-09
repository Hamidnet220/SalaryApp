using System;
using System.Linq;
using SalarApp.Framework;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;

namespace SalaryApp.WinClient.Views.Salary
{
    public partial class List : ViewBase
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());
        private GridControl<Repositoris.Entities.Salary> grid;
        private Repositoris.Entities.Salary salary;

        public List()
        {
            InitializeComponent();
            this.ViewTitle = @"لیست حقوق ها";
        }

        protected override void OnLoad(EventArgs e)
        {
            var salaryList = unitOfWork.Salaries.GetAll().ToList();
            grid = new GridControl<Repositoris.Entities.Salary>(this);
            salary = grid.CurrentItem;
            grid.AddTextBoxColumn("عنوان لیست", s => s.Title);
            grid.AddTextBoxColumn("سال", s => s.Year);
            grid.AddTextBoxColumn("ماه", s => s.Month);
            grid.AddTextBoxColumn("تعداد پرسنل", s => s.EmployeesCount);
            grid.AddTextBoxColumn("وضعیت", s => s.IsLocked);
            grid.SetDataSource(salaryList);
            base.OnLoad(e);
        }

        private void EmployeesList_Click(object sender, EventArgs e)
        {
            var salarDetail=new SalaryDetails.List(grid.CurrentItem);
            salarDetail.Show();
        }
    }
}
