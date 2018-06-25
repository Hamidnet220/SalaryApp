﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.WinClient.Views.Controls;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Workplace
{
    public partial class WorkplaceList : ViewBase
    {
        protected GridControl<Repositoris.Entities.Workplace> grid;

        public WorkplaceList()
        {
            InitializeComponent();
            ViewTitle = @"لیست کارگاه ها";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Repositoris.Entities.Workplace>(unitOfWork.Workplaces.GetAll().Where(w => w.IsDeleted == false).ToList());
            grid.AddColumn("عنوان کارگاه ", w => w.Title);
            grid.AddColumn("آدرس", w => w.Address);
            grid.AddColumn("نام کارفرما", w => w.EmployerTitle);
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