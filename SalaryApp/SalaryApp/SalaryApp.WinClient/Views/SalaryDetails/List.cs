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
        private GridControl<Employee> _grid;
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
            _grid = new GridControl<Employee>(employees);
            _grid.AddColumn("نام", emp=>emp.FirstName);
            _grid.AddColumn("نام خانوادگی", emp=>emp.LastName);
            _grid.AddColumn("نام پدر", emp => emp.FatherName);
            _grid.AddColumn("کد ملی", emp => emp.NationalCode);
            _grid.AddColumn("شماره شناسنامه", emp => emp.IdNumber);
            _grid.AddColumn("شماره حساب", emp => emp.BankAccNumber1);
            this.Controls.Add(_grid);
            _grid.BringToFront();

            base.OnLoad(e);
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var selectEmployeeView=new EmployeesList(_currenMonthSalary);
            


        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (_grid.CurrentItem==null) return;
            var currentItem= unitOfWork.SalaryDetails.Find(s=>s.Employee.Id==_grid.CurrentItem.Id).FirstOrDefault();
            unitOfWork.SalaryDetails.Remove(currentItem);
            unitOfWork.Complete();
            _grid.RemoveCurrent();
        }
    }
}
