using System;
using System.Linq;
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
            var workplaceList = unitOfWork.Workplaces.GetAll().Where(w => w.IsDeleted == false).ToList();
            grid = new GridControl<Repositoris.Entities.Workplace>(this);
            grid.AddTextBoxColumn("عنوان کارگاه ", w => w.Title);
            grid.AddTextBoxColumn("آدرس", w => w.Address);
            grid.AddTextBoxColumn("نام کارفرما", w => w.EmployerTitle);
            grid.AddTextBoxColumn("کد بیمه ", w => w.InsuranceCode);
            grid.AddTextBoxColumn("شماره قرارداد", w => w.ContractNumber);
            grid.AddTextBoxColumn("مبلغ قرارداد", w => w.ContractPrice);
            grid.AddTextBoxColumn("تاریخ شروع", w => w.StartDate);
            grid.AddTextBoxColumn("تاریخ پایان", w => w.EndDate);
            grid.AddTextBoxColumn("تلفن", w => w.Tel);
            grid.AddTextBoxColumn("فکس", w => w.Fax);
            grid.SetDataSource(workplaceList);

            unitOfWork.Dispose();
            base.OnLoad(e);
        }
    }
}
