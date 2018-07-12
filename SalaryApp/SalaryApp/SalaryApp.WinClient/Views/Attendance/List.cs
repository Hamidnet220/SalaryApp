using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;

namespace SalaryApp.WinClient.Views.Attendance
{
    public class List:Framework.ViewBase
    {
        public List()
        {

            AddAction("جدید", null);
            AddAction("ویرایش", null);
            AddAction("حذف", null);

        }

        protected override void OnLoad(EventArgs e)
        {
            
            

            var unitOfWork=new UnitOfWork(new SalaryAppContext());
            var grid=new GridControl<Repositoris.Entities.Attendance>(this);

            grid.SetDataSource(unitOfWork.Attendances.GetAll());

            grid.AddTextBoxColumn("سال", a => a.Year);
            grid.AddTextBoxColumn("ماه", a => a.Month);
            for (int i = 1; i <= 31; i++)
            {
                grid.AddTextBoxColumn(i.ToString("##"), a => String.Format("a.D{}", i.ToString()));
            }
            
            unitOfWork.Dispose();
            base.OnLoad(e);
        }
    }
}
