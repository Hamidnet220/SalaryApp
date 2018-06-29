using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.Repositoris;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Controls;

namespace SalaryApp.WinClient.Views.Salary
{
    public partial class SalaryDetails : ViewBase<SalaryDetails>
    {
        private GridControl<Employee> grid;
        private Repositoris.Entities.Salary currenList;
        public SalaryDetails(Repositoris.Entities.Salary currentList )
        {
            InitializeComponent();
            this.ViewTitle = "لیست پرسنل ماه جاری";
            this.currenList = currentList;
        }

        protected override void OnLoad(EventArgs e)
        {
            var salaryDetails = unitOfWork.SalaryDetails.GetAll().Where(s => s.SalaryId == currenList.Id);
            var employeeList=new List<Employee>();
            foreach (var item in salaryDetails)
            {
                employeeList.Add(item.Employee);
            }

            grid = new GridControl<Employee>(employeeList);
            grid.AddColumn("نام",emp=>emp.FirstName);
            grid.AddColumn("نام خانوادگی", emp=>emp.LastName);
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
