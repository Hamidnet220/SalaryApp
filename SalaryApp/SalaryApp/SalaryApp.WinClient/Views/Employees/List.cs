using System;
using System.Linq;
using System.Windows.Forms;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

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
                var view=ViewEngin.ViewInForm<Views.Employees.Editor>(null,true);
                if (view.DialogResult == DialogResult.OK)
                {
                    unitOfWork.Employees.Add(view.Entity);
                    unitOfWork.Complete();
                    grid.AddItem(view.Entity);
                }
            });

            AddAction("ویرایش", btn =>
            {
                var view=ViewEngin.ViewInForm<Views.Employees.Editor>(editor =>editor.Entity = grid.CurrentItem, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    unitOfWork.Complete();
                    grid.ResetBindings();
                }

            });


            AddAction("حذف", btn =>
            {
                
                
                    
                if (MessageBox.Show(@"شما در حال حذف اطلاعات هویتی پرسنل انتخاب شده هستید.آیا مطمئن هستید؟",
                        "هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    grid.CurrentItem.IsDeleted = true;
                    unitOfWork.Complete();
                    grid.RemoveCurrent();
                }

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


       

       


    }
}



