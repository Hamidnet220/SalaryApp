using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SalarApp.Framework;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.SalaryDetails
{
    public partial class List : ViewBase
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());
        private GridControl<Employee> grid;
        private readonly Repositoris.Entities.Salary _currenMonthSalary;
        private IEnumerable<SalaryDetail> salaryDetails;



        public List(Repositoris.Entities.Salary currentMonthSalary )
        {
            InitializeComponent();

            this.ViewTitle = "لیست پرسنل ماه جاری";

            this._currenMonthSalary = currentMonthSalary;
        }

        protected override void OnLoad(EventArgs e)
        {
            salaryDetails = unitOfWork.SalaryDetails.GetSalaryDetails(_currenMonthSalary.Id);
            var employees=new List<Employee>();
            foreach (var employee in salaryDetails)
            {
                employees.Add(unitOfWork.Employees.Get(employee.Employee.Id));
            }
            grid = new GridControl<Employee>(this);
            grid.AddTextBoxColumn("نام", emp=>emp.FirstName);
            grid.AddTextBoxColumn("نام خانوادگی", emp=>emp.LastName);
            grid.AddTextBoxColumn("نام پدر", emp => emp.FatherName);
            grid.AddTextBoxColumn("کد ملی", emp => emp.NationalCode);
            grid.AddTextBoxColumn("شماره شناسنامه", emp => emp.IdNumber);
            grid.AddTextBoxColumn("شماره حساب", emp => emp.BankAccNumber1);
            grid.SetDataSource(employees);

            base.OnLoad(e);
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var selectEmployeeView=new EmployeesList(_currenMonthSalary);
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (grid.CurrentItem==null) return;
            var currentItem= unitOfWork.SalaryDetails.Find(s=>s.Employee.Id==grid.CurrentItem.Id).FirstOrDefault();
            unitOfWork.SalaryDetails.Remove(currentItem);
            unitOfWork.Complete();
            grid.RemoveCurrent();
        }
    }
}
