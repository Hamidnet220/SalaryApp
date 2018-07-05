using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SalaryApp.Repositoris;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Controls;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class EmployeeList : ViewBase <Employee>
    {

        protected GridControl<Employee> grid;

        public EmployeeList()
        {
            InitializeComponent();
            this.ViewTitle = "لیست پرسنل";
            this.WindowState = FormWindowState.Maximized;
            
        }

        protected override void OnLoad(EventArgs e)
        {
            var employees = unitOfWork.Employees.GetAll().ToList();
            foreach (var emp in employees)
            {
                if (!emp.BankName1Id.HasValue)
                    continue;
                var bank = unitOfWork.Banks.GetById(emp.BankName1Id.Value).FirstOrDefault();
            }

            grid = new GridControl<Employee>(employees);
            grid.AddColumn("نام", emp => emp.FirstName);
            grid.AddColumn("نام خانوادگی", emp => emp.LastName);
            grid.AddColumn("نام پدر", emp => emp.FatherName);
            grid.AddColumn("کد ملی", emp => emp.NationalCode);
            grid.AddColumn("شماره شناسنامه", emp => emp.IdNumber);
            grid.AddColumn("تاریخ تولد ", emp => emp.DOB);
            grid.AddColumn("محل تولد", emp => emp.POI);
            grid.AddColumn("تاریخ صدور", emp => emp.DOB);
            grid.AddColumn("محل صدر", emp => emp.POI);
            grid.AddColumn("شماره بیمه", emp => emp.IdNumber);
            grid.AddColumn("شماره حساب", emp => emp.BankAccNumber1);
            grid.AddColumn("تعداد فرزند", emp => emp.Children);
            grid.AddColumn("وضعیت کار", emp => emp.IsWorking);
            this.Controls.Add(grid);
            base.OnLoad(e);
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            unitOfWork.Employees.Remove(grid.CurrentItem);
            unitOfWork.Complete();
            grid.RemoveCurrent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var employeeEditor=new Views.Employees.EmployeeEditor(grid.CurrentItem);
            employeeEditor.ShowDialog();
        }


    }
}



