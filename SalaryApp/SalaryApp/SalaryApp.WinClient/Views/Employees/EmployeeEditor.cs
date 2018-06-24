using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Employees
{
    public partial class EmployeeEditor : ViewBase
    {
        private Employee employee;   
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

        }

        private void BindTextBox<TProperty>(TextBox textBox, Expression<Func<Employee, TProperty>> selector)
        {
            var visitor = new PropertyVisitor();
            var propertyName = visitor.GetPropertyName(selector);
            textBox.DataBindings.Add("Text", employee,propertyName);

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
