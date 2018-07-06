using System;
using System.Linq;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Controls;

namespace SalaryApp.WinClient.Views.Companies
{
    public partial class List : ViewBase<Company>
    {
        private GridControl<Company> grid;

        public List()
        {
            InitializeComponent();
            ViewTitle = @"لیست شرکت ها و موسسات";
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            grid = new GridControl<Company>(unitOfWork.Companies.GetAll().Where(c=>c.IsDeleted==false).ToList());
            grid.AddColumn("عنوان شرکت ", c => c.Title);
            grid.AddColumn("آدرس", c => c.Address);
            grid.AddColumn("شماره تماس", c => c.Tel);
            grid.AddColumn("شماره فکس", c => c.Fax);

            this.Controls.Add(grid);
            grid.BringToFront();
            base.OnLoad(e);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var companyEditor = new Editor(new Company());
            companyEditor.ShowDialog();
            grid.SetDataSource(unitOfWork.Companies.GetAll());
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var companyEditor=new Editor(grid.CurrentItem);
            companyEditor.ShowDialog();

            if (companyEditor.DialogResult == DialogResult.OK)
                unitOfWork.Complete();

            grid.ResetBindings();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show(@"آیا از حذف شرکت مطمئن هستید؟",@"حذف شرکت/موسسه",
                MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                unitOfWork.Companies.Remove(grid.CurrentItem);
                unitOfWork.Complete();
            }
            grid.SetDataSource(unitOfWork.Companies.GetAll());
        }
    }
}
