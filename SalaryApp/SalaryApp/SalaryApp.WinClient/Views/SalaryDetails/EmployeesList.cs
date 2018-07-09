using System;
using System.Windows.Forms;
using SalarApp.Framework;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.SalaryDetails
{
    public partial class EmployeesList : ViewBase
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());
        private GridControl<Employee> grid;
        private Repositoris.Entities.Salary salary;

        public EmployeesList(Repositoris.Entities.Salary salary)
        {
            InitializeComponent();
            ViewTitle = @"لیست کارکنان";
            this.salary = salary;
        }
        protected override void OnLoad(EventArgs e)
        {
            var employees = unitOfWork.Employees.GetAll();

            grid = new GridControl<Employee>(this);
            grid.AddCheckBox("وضعیت انتخاب");
            grid.AddTextBoxColumn("نام", emp => emp.FirstName);
            grid.AddTextBoxColumn("نام خانوادگی", emp => emp.LastName);
            grid.AddTextBoxColumn("نام پدر", emp => emp.FatherName);
            grid.AddTextBoxColumn("کد ملی", emp => emp.NationalCode);
            grid.AddTextBoxColumn("شماره شناسنامه", emp => emp.IdNumber);
            grid.AddTextBoxColumn("شماره حساب", emp => emp.BankAccNumber1);
            grid.SetDataSource(employees);

            base.OnLoad(e);
        }


        private void AddEmployee_Click(object sender, EventArgs e)
        {

            
        }
    }
}
