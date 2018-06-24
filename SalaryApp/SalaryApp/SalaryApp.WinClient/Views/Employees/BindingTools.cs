using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient.Views.Employees
{
    public class BindingTools<TEntity> where TEntity:class 
    {
        private TEntity _entity;

        public BindingTools(TEntity entity)
        {
            _entity = entity;
        }

        public  void BindTextBox<TProperty>(TextBox textBox, Expression<Func<TEntity, TProperty>> selector)
        {
            var visitor = new ExperssionHandler();
            var propertyName = visitor.GetPropertyName(selector);
            textBox.DataBindings.Add("Text", _entity,propertyName);

        }

        public  void BindComboBox<TProperty,TComboItem,TEntity>(ComboBox comboBox,
            List<TComboItem> items,
            string title,
            Expression<Func<TComboItem,string>> displayMemeber,
            Expression<Func<TComboItem,TProperty>> valueMemebr, 
            int? value)
        {

            var propertyVisitro = new ExperssionHandler();
            comboBox.DataSource = items;
            comboBox.DisplayMember = propertyVisitro.GetPropertyName(displayMemeber);
            comboBox.ValueMember = propertyVisitro.GetPropertyName(valueMemebr);
            comboBox.Text =title;

            if (value.HasValue)
            {
                comboBox.SelectedValue = value;
            }
        }
    }
}