using System;
using System.Linq;
using SalaryApp.WinClient.Views.Controls;
namespace SalaryApp.WinClient.Views.Salary
{
    public partial class List : ViewBase<List>
    {
        private GridControl<Repositoris.Entities.Salary> _grid;
        private Repositoris.Entities.Salary _salary;

        public List()
        {
            InitializeComponent();
            this.ViewTitle = @"لیست حقوق ها";
        }

        protected override void OnLoad(EventArgs e)
        {
            _grid = new GridControl<Repositoris.Entities.Salary>(unitOfWork.Salaries.GetAll().ToList());
            _salary = _grid.CurrentItem;
            _grid.AddColumn("عنوان لیست", s => s.Title);
            _grid.AddColumn("سال", s => s.Year);
            _grid.AddColumn("ماه", s => s.Month);
            _grid.AddColumn("تعداد پرسنل", s => s.EmployeesCount);
            _grid.AddColumn("وضعیت", s => s.IsLocked);
            this.Controls.Add(_grid);
            _grid.BringToFront();
            base.OnLoad(e);
        }

        private void EmployeesList_Click(object sender, EventArgs e)
        {
            var salarDetail=new SalaryDetails.List(_grid.CurrentItem);
            salarDetail.Show();
        }
    }
}
