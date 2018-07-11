using System;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Companies
{
    public partial class Editor :Framework.EntityEditor<Company>
    {
        protected readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());
        private Company companyCopy=new Company();
        public Editor()
        {
            InitializeComponent();
        }

        public override string ViewTitle
        {
            get
            {
                if (Entity.Id == 0)
                    return "تعریف شرکت/موسسه جدید";
                return "ویرایش شرکت/موسسه";
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {


            BindTextBox(TitleTextBox,c=> c.Title);
            BindTextBox(TelTextBox,c=>c.Tel);
            BindTextBox(FaxTextBox,c=>c.Fax);
            BindTextBox(AddressTextBox,c=>c.Address);
            
            base.OnLoad(e);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
