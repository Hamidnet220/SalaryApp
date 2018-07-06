using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.Repositoris;

namespace SalaryApp.WinClient
{
    public class ViewBase<TEntity>:Form where TEntity:class
    {
        protected virtual string ViewTitle { get; set; }
        protected readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        protected ViewBase()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.Font = new Font("tahoma", 9);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            Text = ViewTitle;
            base.OnLoad(e);
        }
    }
}
