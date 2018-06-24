using System;
using System.Windows.Forms;
using SalaryApp.Repositoris;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class EmployeeList : ViewBase
    {
        private DataGridView employeeListDataGrid;
        private BindingSource bindigSource;
        public EmployeeList()
        {
            InitializeComponent();
            this.ViewTitle = "لیست پرسنل";
            this.WindowState = FormWindowState.Maximized;
            this.Load += EmployeeList_Load;

        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            employeeListDataGrid=new DataGridView();
            this.Controls.Add(employeeListDataGrid);

            //Start Styling DataGridView
            employeeListDataGrid.Dock = DockStyle.Fill;
            employeeListDataGrid.AllowUserToAddRows = false;
            employeeListDataGrid.AllowUserToDeleteRows = false;
            employeeListDataGrid.EditMode=DataGridViewEditMode.EditProgrammatically;
            employeeListDataGrid.AutoGenerateColumns = false;
            employeeListDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeListDataGrid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            //End Styling DataGridView

            //Add Columns to DataGird View
            AddTextBoxColumnToGrid(employeeListDataGrid,"نام","FirstName");
            AddTextBoxColumnToGrid(employeeListDataGrid,"نام خانوادگی","LastName");
            AddTextBoxColumnToGrid(employeeListDataGrid,"نام پدر","FatherName");
            AddTextBoxColumnToGrid(employeeListDataGrid,"شماره ملی","NationalCode");
            AddTextBoxColumnToGrid(employeeListDataGrid, "شماره شناسنامه", "IdNumber");
            AddTextBoxColumnToGrid(employeeListDataGrid,"تاریخ تولد","DOB");
            AddTextBoxColumnToGrid(employeeListDataGrid,"محل تولد","POB");
            AddTextBoxColumnToGrid(employeeListDataGrid,"نام بانک","BankName1");
            AddTextBoxColumnToGrid(employeeListDataGrid,"شماره حساب","BankAccount1");




            using (var unitOfWork = new UnitOfWork(new SalaryAppContext()))
            {
                var employees=unitOfWork.Employees.GetAll();
                bindigSource=new BindingSource();
                bindigSource.DataSource = employees;
                employeeListDataGrid.DataSource =bindigSource;
                unitOfWork.Complete();
            }
        }

        //Add Column to DataGrid Method
        private void AddTextBoxColumnToGrid(DataGridView grid, string columnName, string propertyName)
        {
            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = columnName,
                DataPropertyName = propertyName
            });
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟","هشدار",MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var unitOfWork=new UnitOfWork(new SalaryAppContext()))
            {
                var employee =(Employee) bindigSource.Current;
                unitOfWork.Employees.Remove(employee);
                unitOfWork.Complete();
                bindigSource.RemoveCurrent();
                employeeListDataGrid.Update();
                employeeListDataGrid.Refresh();
            }
        }

       
        private void EditButton_Click(object sender, EventArgs e)
        {
            var employee = (Employee)bindigSource?.Current;
            if (employee != null)
            {
                var employeeEditor=new EmployeeEditor(employee);
                employeeEditor.ShowDialog();
            }
        }
    }
}
