using System;
using System.Linq;
using System.Windows.Forms;
using SalarApp.Framework;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Companies
{
    public partial class List : ViewBase
    {
        private GridControl<Company> grid;
        protected readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        public List()
        {
            InitializeComponent();
            ViewTitle = @"لیست شرکت ها و موسسات";
            AddAction("حذف", btn =>
            {
                if(MessageBox.Show(@"آیا حذف شرکت مورد نظر را تایید می کنید",@"حذف شرکت/موسسه",
                    MessageBoxButtons.YesNo)!=DialogResult.Yes)
                    return;

                grid.CurrentItem.IsDeleted = true;
                unitOfWork.Complete();
                grid.RemoveCurrent();
                
            });

            AddAction("ویرایش", btn =>
            {
               var view= ViewEngin.ViewInForm<Views.Companies.Editor>(editor =>
                {
                    editor.Entity = grid.CurrentItem;
                });

                if (view.DialogResult == DialogResult.OK)
                {
                    unitOfWork.Complete();
                    grid.ResetBindings();
                }
            });

            AddAction("جدید", btn =>
            {
                var view = ViewEngin.ViewInForm<Views.Companies.Editor>(null, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    unitOfWork.Companies.Add(view.Entity);
                    unitOfWork.Complete();
                    grid.ResetBindings();
                }

            });

            AddAction("انصراف", btn =>
            {
                CloseView(DialogResult.Cancel);
                unitOfWork.Dispose();
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            var companies = unitOfWork.Companies.GetAll().Where(c => c.IsDeleted == false).ToList();
            grid = new GridControl<Company>(this);
            grid.AddTextBoxColumn("عنوان شرکت ", c => c.Title);
            grid.AddTextBoxColumn("آدرس", c => c.Address);
            grid.AddTextBoxColumn("شماره تماس", c => c.Tel);
            grid.AddTextBoxColumn("شماره فکس", c => c.Fax);

            grid.SetDataSource(companies);

            
            base.OnLoad(e);
        }

       
        
    }
}
