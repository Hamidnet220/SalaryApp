using System;
using System.Linq;
using System.Windows.Forms;
using SalarApp.Framework;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;

namespace SalaryApp.WinClient.Views.Workplace
{
    public partial class List : ViewBase
    {
        private GridControl<Repositoris.Entities.Workplace> grid;
        private readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        public List()
        {
            ViewTitle = @"لیست کارگاه ها";
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Repositoris.Entities.Workplace>(unitOfWork.Workplaces.GetAll().Where(w => w.IsDeleted == false).ToList());
            grid.AddColumn("عنوان کارگاه ", w => w.Title);
            grid.AddColumn("آدرس", w => w.Address);
            grid.AddColumn("نام کارفرما", w => w.EmployerTitle);
            grid.AddColumn("کد بیمه ", w => w.InsuranceCode);
            grid.AddColumn("شماره قرارداد", w => w.ContractNumber);
            grid.AddColumn("مبلغ قرارداد", w => w.ContractPrice);
            grid.AddColumn("تاریخ شروع", w => w.StartDate);
            grid.AddColumn("تاریخ پایان", w => w.EndDate);
            grid.AddColumn("تلفن", w => w.Tel);
            grid.AddColumn("فکس", w => w.Fax);

            this.Controls.Add(grid);
            base.OnLoad(e);
        }
    }
}
