using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Controls;

namespace SalaryApp.WinClient.Views.Salary
{
    public partial class SalaryDetails : ViewBase<SalaryDetails>
    {
        public SalaryDetails()
        {
            this.ViewTitle = "لیست پرسنل ماه جاری";
        }

        protected override void OnLoad(EventArgs e)
        {
        //    grid = new GridControl<SalaryDetail>(unitOfWork.SalaryDetails.GetAll());
        //    grid.AddColumn("نام", emp => emp.FirstName);
        //    grid.AddColumn("نام خانوادگی", emp => emp.LastName);
        //    grid.AddColumn("نام پدر", emp => emp.FatherName);
        //    grid.AddColumn("کد ملی", emp => emp.NationalCode);
        //    grid.AddColumn("شماره شناسنامه", emp => emp.IdNumber);
        //    grid.AddColumn("تاریخ تولد ", emp => emp.DOB);
        //    grid.AddColumn("محل تولد", emp => emp.POIId);
        //    grid.AddColumn("تاریخ صدور", emp => emp.DOB);
        //    grid.AddColumn("محل صدر", emp => emp.POIId);
        //    grid.AddColumn("شماره بیمه", emp => emp.IdNumber);
        //    grid.AddColumn("نام بانک", emp => emp.LastName);
        //    grid.AddColumn("شماره حساب", emp => emp.BankAccNumber1);

        //    this.Controls.Add(grid);
            base.OnLoad(e);
        }
    }
}
