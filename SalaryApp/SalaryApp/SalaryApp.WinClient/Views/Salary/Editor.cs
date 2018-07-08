using System;
using SalaryApp.Framework;

namespace SalaryApp.WinClient.Views.Salary
{
    public class Editor:ViewBase
    {
        private Repositoris.Entities.Salary salary;
        public Editor(Repositoris.Entities.Salary salary)
        {
            this.salary = salary;
            ViewTitle = @"ویرایش حقوق";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(520, 324);
            this.Name = "Editor";
            this.ResumeLayout(false);

        }
    }
}
