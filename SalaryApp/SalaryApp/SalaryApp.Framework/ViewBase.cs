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

        protected override void OnLoad(EventArgs e)
        {
            if (VisibleTopBar)
            {
                TopButtonsBar.Visible = true;
                TopButtonsBar.BringToFront();
            }
            base.OnLoad(e);
        }

        public bool VisibleTopBar { get; set; }
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

        protected Button AddTopAction(string title, Action<Button> onClick, bool mutliline = false)
        {
            var button = new Button();
            button.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            button.Text = title;

            button.Click += (obj, e) =>
            {
                onClick(button);
            };
            var totalButton = TopButtonsBar.Controls.Count;
            var left =TopButtonsBar.Width-( ((totalButton + 1) * 10) + ((totalButton+1) * 90));
            button.Location = new Point(left, 10);

            if (mutliline)
                button.Size = new Size(90, 50);
            else
                button.Size = new Size(90, 23);

            TopButtonsBar.Controls.Add(button);
            return button;
        }

        protected Button AddAction(string title, Action<Button> onClick,bool mutliline=false)
        {
            var button=new Button();
            
            button.Text = title;
            button.Click += (obj, e) =>
            {
                onClick(button);
            };
            var totalButton = ButtonsBar.Controls.Count;
            var left = ((totalButton + 1) * 10) + (totalButton*85);
            button.Location=new Point(left, 7);
            
            if(mutliline)
                button.Size=new Size(90,50);
            else
                button.Size = new Size(90, 23);

            ButtonsBar.Controls.Add(button);
            return button;
        }

        protected void CloseView(DialogResult? dialogResult=null)
        {
            ViewEngin.CloseView(this,dialogResult);
        }
    }
}
