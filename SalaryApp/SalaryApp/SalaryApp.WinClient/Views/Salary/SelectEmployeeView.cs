using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Controls;

namespace SalaryApp.WinClient.Views.Salary
{
    public class SelectEmployeeView:ViewBase<Employee>
    {
        private GridControl<Employee> grid;
        public SelectEmployeeView()
        {
            ViewTitle = @"لیست کارکنان";
            WindowState=FormWindowState.Maximized;
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
    }
}
