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
            var employeeList = unitOfWork.Employees.GetAll();

            grid = new GridControl<Employee>(employeeList);
            grid.AddCheckBox("وضعیت انتخاب");
            grid.AddColumn("نام", emp => emp.FirstName);
            grid.AddColumn("نام خانوادگی", emp => emp.LastName);
            grid.AddColumn("نام پدر", emp => emp.FatherName);
            grid.AddColumn("کد ملی", emp => emp.NationalCode);
            grid.AddColumn("شماره شناسنامه", emp => emp.IdNumber);
            grid.AddColumn("شماره حساب", emp => emp.BankAccNumber1);
            this.Controls.Add(grid);
            grid.BringToFront();
            base.OnLoad(e);
        }


        private void AddEmployee_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                unitOfWork.SalaryDetails.Add(new SalaryDetail
                {
                    SalaryId = salary.Id,
                    Employee = (Employee)row.DataBoundItem
                });
            }
            unitOfWork.Complete();
            
        }
    }
}
