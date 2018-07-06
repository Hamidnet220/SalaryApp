using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;
using SalaryApp.WinClient.Views.Employees;

namespace SalaryApp.WinClient.Views.Companies
{
    public partial class Editor : ViewBase<Company>
    {
        private Company company;
        private Company companyCopy=new Company();
        private BindingTools<Company> bindingTools;
        public Editor(Company company)
        {
            this.company = company;
            InitializeComponent();
            ViewTitle = @"ویرایش شرکت/موسسه";
        }

        protected override void OnLoad(EventArgs e)
        {
            var companyPropeties = typeof(Company).GetProperties();

            foreach (var propety in companyPropeties)
            {
                propety.SetValue(companyCopy,propety.GetValue(company));
            }

            bindingTools=new BindingTools<Company>(companyCopy);

            bindingTools.BindTextBox(TitleTextBox,c=>c.Title);
            bindingTools.BindTextBox(TelTextBox,c=>c.Tel);
            bindingTools.BindTextBox(FaxTextBox,c=>c.Fax);
            bindingTools.BindTextBox(AddressTextBox,c=>c.Address);
            base.OnLoad(e);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var companyPropeties = typeof(Company).GetProperties();

            foreach (var propety in companyPropeties)
            {
                propety.SetValue(company , propety.GetValue(companyCopy));
            }

            if (company.Id == 0)
            {
                company.CreateDate=DateTime.Now;
                unitOfWork.Companies.Add(company);
                unitOfWork.Complete();
                Close();
                return;
            }

            DialogResult=DialogResult.OK;
            Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
           
        }
    }
}
