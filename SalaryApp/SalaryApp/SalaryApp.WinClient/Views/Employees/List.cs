using System;
using System.Linq;
using System.Windows.Forms;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.Migrations;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class List : ViewBase 
    {

        protected GridControl<Employee> grid;
        protected readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        public List()
        {
            InitializeComponent();
            this.ViewTitle = "لیست پرسنل";
            AddAction("پرسنل جدید", btn =>
            {
                MessageBox.Show("مشتری جدید");
            });

            AddAction("ویرایش", btn =>
            {
                ViewEngin.ViewInForm<Views.Employees.Editor>(null,true);
            });

        }

        protected override void OnLoad(EventArgs e)
        {
            var employees = unitOfWork.Employees.GetAll().ToList();
            grid = new GridControl<Employee>(this);

            grid.AddTextBoxColumn("نام", emp => emp.FirstName);
            grid.AddTextBoxColumn("نام خانوادگی", emp => emp.LastName);
            grid.AddTextBoxColumn("نام پدر", emp => emp.FatherName);
            grid.AddTextBoxColumn("کد ملی", emp => emp.NationalCode);
            grid.AddTextBoxColumn("شماره شناسنامه", emp => emp.IdNumber);
            grid.AddTextBoxColumn("تاریخ تولد ", emp => emp.DOB);
            grid.AddTextBoxColumn("محل تولد", emp => emp.POI);
            grid.AddTextBoxColumn("تاریخ صدور", emp => emp.DOB);
            grid.AddTextBoxColumn("محل صدر", emp => emp.POI);
            grid.AddTextBoxColumn("شماره بیمه", emp => emp.IdNumber);
            grid.AddTextBoxColumn("شماره حساب", emp => emp.BankAccNumber1);
            grid.AddTextBoxColumn("تعداد فرزند", emp => emp.Children);
            grid.AddTextBoxColumn("وضعیت کار", emp => emp.IsWorking);
            grid.SetDataSource(employees);
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
          
        }


    }
}



