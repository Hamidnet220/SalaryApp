using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalaryApp.Repositoris;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class EmployeeEditor : ViewBase
    {
        private readonly Employee _employee;   
        private readonly UnitOfWork _unitOfWork=new UnitOfWork(new SalaryAppContext());

        public EmployeeEditor(Employee employee)
        {
            _employee = employee;

            InitializeComponent();

            this.WindowState=FormWindowState.Maximized;
            BankNameComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            POBComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            POIComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            Load += EmployeeEditor_Load;
        }

        private void EmployeeEditor_Load(object sender, EventArgs e)
        {
            InitialFormDataBinding();
        }

        public override string ViewTitle
        {
            get { return "ویرایش اطلاعات کارکنان"; }
        }

        private void InitialFormDataBinding()
        {
            var editorView = new EditorView<Employee>(_employee);

            editorView.BindTextBox(FirstNameTextBox, emp => emp.FirstName);
            editorView.BindTextBox(LastNameTextBox, emp => emp.LastName);
            editorView.BindTextBox(FatherNameTextBox, emp => emp.FatherName);
            editorView.BindTextBox(NationalCodeTextBox, emp => emp.NationalCode);
            editorView.BindTextBox(IdNumberTextBox, emp => emp.IdNumber);


            editorView.BindComboBox<int?, Bank, Employee>(BankNameComboBox,
                _unitOfWork.Banks.GetAll().ToList(),
                "نامشخص",
                b => b.Title,
                b => b.Id,
                _employee.BankName1Id);

            editorView.BindComboBox<int?, City, Employee>(POBComboBox,
                _unitOfWork.Cities.GetAll().ToList(),
                "نامشخص",
                c => c.CityName,
                c => c.Id,
                _employee.POBId);

            editorView.BindComboBox<int?, City, Employee>(POIComboBox,
                _unitOfWork.Cities.GetAll().ToList(),
                "نامشخص",
                c => c.CityName,
                c => c.Id,
                _employee.POIId);
        }
    }
}
