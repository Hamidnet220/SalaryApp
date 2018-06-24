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
        private Employee employee;   
        private UnitOfWork unitOfWork=new UnitOfWork(new SalaryAppContext());
        public EmployeeEditor(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            this.WindowState=FormWindowState.Maximized;
            BankNameComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            Load += EmployeeEditor_Load;
        }

        public override string ViewTitle
        {
            get { return "ویرایش اطلاعات کارکنان"; }
           
        }

        private void EmployeeEditor_Load(object sender, EventArgs e)
        {
            BindTextBox(FirstNameTextBox,emp=>emp.FirstName);
            BindTextBox(LastNameTextBox,emp=>emp.LastName);
            BindTextBox(FatherNameTextBox,emp=>emp.FatherName);
            BindTextBox(NationalCodeTextBox,emp=>emp.NationalCode);
            BindTextBox(IdNumberTextBox,emp=>emp.IdNumber);

            BindComboBox(BankNameComboBox,unitOfWork.Banks.GetAll().ToList(),"Title","Id",employee.BankName1Id);
            
        }

        private void BindTextBox<TProperty>(TextBox textBox, Expression<Func<Employee, TProperty>> selector)
        {
            var visitor = new PropertyVisitor();
            var propertyName = visitor.GetPropertyName(selector);
            textBox.DataBindings.Add("Text", employee,propertyName);

        }

        private void BindComboBox<TComboItem>(ComboBox comboBox, List<TComboItem> items, string displayMemeber,
            string valueMemebr, int? value)
        {
            if (value.HasValue)
            {
                BankNameComboBox.DataSource = items;
                BankNameComboBox.DisplayMember = displayMemeber;
                BankNameComboBox.ValueMember = valueMemebr;
                BankNameComboBox.SelectedValue = value;

            }
        }
    }

    internal class PropertyVisitor:ExpressionVisitor
    {
        List<string> propertyNames=new List<string>();

        public string GetPropertyName(Expression exp)
        {
            Visit(exp);
            propertyNames.Reverse();
            return string.Join(".", propertyNames);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            propertyNames.Add(node.Member.Name);
            return base.VisitMember(node);
        }
    }
}
