using System;
using System.Linq;
using System.Windows.Forms;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class Editor : ViewBase
    {
        private readonly Employee employee;
        protected readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        public Editor(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            BankNameComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            POBComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            POIComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

        }


        protected override void OnLoad(EventArgs e)
        {
            var bindingTools = new BindingTools<Employee>(employee);

            bindingTools.BindTextBox(FirstNameTextBox, emp => emp.FirstName);
            bindingTools.BindTextBox(LastNameTextBox, emp => emp.LastName);
            bindingTools.BindTextBox(FatherNameTextBox, emp => emp.FatherName);
            bindingTools.BindTextBox(NationalCodeTextBox, emp => emp.NationalCode);
            bindingTools.BindTextBox(IdNumberTextBox, emp => emp.IdNumber);
            bindingTools.BindTextBox(Account1TextBox, emp => emp.BankAccNumber1);
            bindingTools.BindMaskTextBox(DateOfBorn, emp => emp.DOB);

            bindingTools.BindComboBox<int?, Bank, Employee>(BankNameComboBox,
                unitOfWork.Banks.GetAll().ToList(),
                "نام بانک ",
                b => b.Title,
                b => b.Id,
                employee.BankName1Id);

            bindingTools.BindComboBox<int?, City, Employee>(POBComboBox,
                unitOfWork.Cities.GetAll().ToList(),
                "محل تولد",
                c => c.CityName,
                c => c.Id,
                employee.POB);

            bindingTools.BindComboBox<int?, City, Employee>(POIComboBox,
                unitOfWork.Cities.GetAll().ToList(),
                "محل صدور",
                c => c.CityName,
                c => c.Id,
                employee.POI);

            bindingTools.BindComboBox<int?, Country, Employee>(CountryComboBox,
                unitOfWork.Countries.GetAll().ToList(),
                "نام کشور",
                c => c.Title,
                c => c.Id,
                employee.POI);


            base.OnLoad(e);
        }

        

        

    }
}
