using System;
using System.Linq;
using SalaryApp.Framework;
using SalaryApp.Repositoris.DataLayer;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class Editor : EntityEditor<Employee>
    {
        protected readonly UnitOfWork unitOfWork = new UnitOfWork(new SalaryAppContext());

        public Editor()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {

            BindTextBox(FirstNameTextBox, emp => emp.FirstName);
            BindTextBox(LastNameTextBox, emp => emp.LastName);
            BindTextBox(FatherNameTextBox, emp => emp.FatherName);
            BindTextBox(NationalCodeTextBox, emp => emp.NationalCode);
            BindTextBox(IdNumberTextBox, emp => emp.IdNumber);
            BindTextBox(Account1TextBox, emp => emp.BankAccNumber1);
            BindMaskTextBox(DateOfBorn, emp => emp.DOB);

            BindComboBox(BankNameComboBox,
                emp => emp.BankName1Id,
                "نام بانک ",
                unitOfWork.Banks.GetAll().ToList(),
                b => b.Title,
                b => b.Id);

            BindComboBox(POBComboBox,
                emp => emp.POB,
                "محل تولد",
                unitOfWork.Cities.GetAll().ToList(),
                c => c.CityName,
                c => c.Id);

            BindComboBox(POIComboBox,
                emp => emp.POI,
                "محل صدور",
                unitOfWork.Cities.GetAll().ToList(),
                c => c.CityName,
                c => c.Id);

            BindComboBox(CountryComboBox,
                emp => emp.CountryId,
                "نام کشور",
                unitOfWork.Countries.GetAll().ToList(),
                c => c.Title,
                c => c.Id);



            base.OnLoad(e);
        }

        public override string ViewTitle
        {
            get
            {
                if (Entity.Id == 0)
                    return "ایجاد پرسنل جدید";
                return "ویرایش پرسنل";
            }
        }
    }
}
