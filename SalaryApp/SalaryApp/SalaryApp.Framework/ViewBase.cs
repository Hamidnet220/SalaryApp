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
        
        public DialogResult DialogResult { get; set; }

        public virtual string ViewTitle { get; set; }

        public virtual string ViewIdentifier
        {
            get { return this.GetType().FullName; }
            
        }

        public ViewEngin ViewEngin
        {
            get;
            internal set;
        }

        protected Button AddAction(string title, Action<Button> onClick)
        {
            var button=new Button();
            button.Text = title;
            button.Click += (obj, e) =>
            {
                onClick(button);
            };
            var totalButton = ButtonsBar.Controls.Count;
            var left = ((totalButton + 1) * 5) + (totalButton*85);
            button.Location=new Point(left, 7);
            button.Size=new Size(85,23);
            ButtonsBar.Controls.Add(button);
            return button;
        }

        protected void CloseView(DialogResult? dialogResult=null)
        {
            ViewEngin.CloseView(this,dialogResult);
        }
    }
}
