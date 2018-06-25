using System;
using System.Linq;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Employees;

namespace SalaryApp.WinClient.Views.Companies
{
    public partial class CompaniesList : ViewBase
    {
        protected GridControl<Company> grid;
        public CompaniesList()
        {
            InitializeComponent();
            ViewTitle = @"لیست شرکت ها و موسسات";
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Company>(unitOfWork.Companies.GetAll().Where(c=>c.IsDeleted==false).ToList());
            grid.AddColumn("عنوان شرکت ", c => c.Title);
            grid.AddColumn("آدرس", c => c.Address);
            this.Controls.Add(grid);
            base.OnLoad(e);
        }
    }
}
