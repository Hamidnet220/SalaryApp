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
        public virtual string ViewTitle { get; set; }
        protected UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        public ViewBase()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.Font = new Font("tahoma", 9);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

        }

        protected override void OnLoad(EventArgs e)
        {
            this.Text = ViewTitle;
            base.OnLoad(e);
        }
    }
}
