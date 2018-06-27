using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.WinClient.Views.Controls;

namespace SalaryApp.WinClient.Views.Salary
{
    public partial class SalaryList : ViewBase
    {
        protected GridControl<Repositoris.Entities.Salary> grid;

        public SalaryList()
        {
            InitializeComponent();
            this.ViewTitle = @"لیست حقوق ها";
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Repositoris.Entities.Salary>(unitOfWork.Salaries.GetAll().ToList());
            grid.AddColumn("عنوان لیست", s => s.Title);
            grid.AddColumn("سال", s => s.Year);
            grid.AddColumn("ماه", s => s.Month);
            grid.AddColumn("تعداد پرسنل", s => s.EmployeesCount);
            grid.AddColumn("وضعیت", s => s.IsLocked);
            this.Controls.Add(grid);
            grid.BringToFront();
            base.OnLoad(e);
        }

        
    }
}
