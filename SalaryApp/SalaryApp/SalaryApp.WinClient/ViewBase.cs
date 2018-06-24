using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryApp.WinClient
{
    public partial class ViewBase : Form
    {
        public ViewBase()
        {
            InitializeComponent();
            this.RightToLeft=RightToLeft.Yes;
            this.Font=new Font("tahoma",9);
            this.Load += ViewBase_Load;
        }

        private void ViewBase_Load(object sender, EventArgs e)
        {
            this.Text = ViewTitle;
        }

        public virtual string ViewTitle { get; set; }
        
    }
}
