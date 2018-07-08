using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryApp.Framework
{
    public partial class ViewBase : UserControl
    {
        public ViewBase()
        {
            InitializeComponent();
        }

        public virtual string ViewTitle { get; set; }

        public virtual string ViewIdentifier
        {
            get { return this.GetType().FullName; }
            
        }

        protected Button AddAction(string title, Action<Button> onClick)
        {
            var button=new Button();
            button.Text = title;
            button.Click += (obj, e) =>
            {
                onClick(button);
            };
            button.Location=new Point(10,8);
            button.Size=new Size(75,23);
            ButtonsBar.Controls.Add(button);
            return null;
        }
    }
}
