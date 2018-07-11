using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalarApp.Framework;


namespace SalaryApp.Framework
{
    public class EntityEditor<TEntity> : ViewBase where TEntity : class, new()
    {
        public TEntity Entity { get; set; }
        private TEntity entityCopy;
        private List<EntityEditorControl> createdControls = new List<EntityEditorControl>();

        public EntityEditor()
        {

            //if user hit Accept button in editor view
            Entity = new TEntity();
            AddAction("تایید", btn => CloseView(dialogResult: DialogResult.OK));

            //if user hit Cancel button all value in Entity will reset to origin.
            AddAction("صرفنظر", btn =>
            {
                var entityProperties = typeof(TEntity).GetProperties();

                foreach (var property in entityProperties)
                {
                    property.SetValue(Entity, property.GetValue(entityCopy));
                }

                CloseView(dialogResult: DialogResult.Cancel);
            });

            //Copy all properties in Entity in entitycopy when object is load.
            Load+= (sender, e) =>
            {
                entityCopy=new TEntity();
                var entityProperties = typeof(TEntity).GetProperties();

                foreach (var property in entityProperties)
                {
                    property.SetValue(entityCopy,property.GetValue(Entity));
                }
            };
        }

        //add text box 
        protected TextBox TextBox<TProperty>(Expression<Func<TEntity, TProperty>> selector,
            string title, bool mutliline = false)
        {
            var label = new Label();
            label.Text = title;
            label.AutoSize = true;

            var textBox = new TextBox();
            var expressionHandler = new ExperssionHandler();
            this.Controls.Add(label);
            this.Controls.Add(textBox);

            textBox.DataBindings.Add("Text", Entity, expressionHandler.GetPropertyName(selector));
            textBox.Left = 20;
            textBox.Top = 10;
            textBox.Width = 200;
            textBox.Multiline = true;
            if (mutliline)
            {
                textBox.ScrollBars = ScrollBars.Vertical;
                textBox.Height = 120;
            }
            createdControls.Add(new EntityEditorControl()
            {
                Label = label,
                Control = textBox,
                Priority = createdControls.Count + 1
            });
            return textBox;
        }

        //binding text box 
        protected void BindTextBox<TProperty>(TextBox textBox, Expression<Func<TEntity, TProperty>> selector)
        {
            var experssionHandler = new ExperssionHandler();
            textBox.DataBindings.Add("Text", Entity, experssionHandler.GetPropertyName(selector));

        }

        //binding masktextbox
        protected void BindMaskTextBox<TProperty>(MaskedTextBox maskedTextBox, Expression<Func<TEntity, TProperty>> selector)
        {
            var experssionHandler = new ExperssionHandler();
            maskedTextBox.DataBindings.Add("Text", Entity, experssionHandler.GetPropertyName(selector));

        }

        //add combo box
        protected ComboBox ComboBox<TProperty, TComboItem>(Expression<Func<TEntity, TProperty>> selector, string title,
            List<TComboItem> items, Expression<Func<TComboItem, string>> displaySelector,
            Expression<Func<TComboItem, TProperty>> valueSelector)
        {
            var expressionHandler = new ExperssionHandler();
            var label = new Label();
            label.Text = title;
            label.AutoSize = true;
            this.Controls.Add(label);

            var comboBox = new ComboBox();
            comboBox.DataBindings.Add("SelectedValue", Entity, expressionHandler.GetPropertyName(selector));
            comboBox.DataSource = items;
            comboBox.DisplayMember = expressionHandler.GetPropertyName(displaySelector);
            comboBox.ValueMember = expressionHandler.GetPropertyName(valueSelector);
            comboBox.DropDownStyle=ComboBoxStyle.DropDownList;
            this.Controls.Add(comboBox);

            createdControls.Add(new EntityEditorControl()
            {
                Label = label,
                Control = comboBox,
                Priority = createdControls.Count + 1
            });

            return comboBox;
        }

        //add true-false combobox 
        protected ComboBox TrueFalseComboBox(Expression<Func<TEntity, bool>> selector, string title)
        {
            List<ComboItem<bool>> items = new List<ComboItem<bool>>();

            items.Add(new ComboItem<bool> { Display = "بله", value = true });
            items.Add(new ComboItem<bool> { Display = "خیر", value = false });

            return ComboBox(selector, title, items, item => item.Display, item => item.value);

        }

        //biniding a combobox
        protected void BindComboBox<TProperty, TComboItem>(ComboBox comboBox,
            Expression<Func<TEntity, TProperty>> selector,
            string title,
            List<TComboItem> items,
            Expression<Func<TComboItem, string>> displaySelector,
            Expression<Func<TComboItem, TProperty>> valueSelector)
        {
            var experssionHandler = new ExperssionHandler();
            comboBox.Text = title;
            comboBox.DataBindings.Add("SelectedValue", Entity, experssionHandler.GetPropertyName(selector));
            comboBox.DataSource = items;
            comboBox.DisplayMember = experssionHandler.GetPropertyName(displaySelector);
            comboBox.ValueMember = experssionHandler.GetPropertyName(valueSelector);


        }


        public void AdjustControls()
        {
            var currentTop = 10;
            var maxLabelWidth = createdControls.Select(c => c.Label).Max(l => l.Width);

            foreach (var control in createdControls.OrderBy(c => c.Priority))
            {
                control.Label.Left = (this.Width - control.Label.Width) - 10;
                control.Label.Top = currentTop;

                control.Control.Width = (this.Width) - 10 - maxLabelWidth - 20;
                control.Control.Top = currentTop;
                control.Control.Left = 10;

                currentTop += control.Control.Height + 10;
            }

            createdControls.OrderBy(c => c.Priority).First().Control.Focus();
            this.Parent.Height = currentTop + 80;
        }
    }

    public class EntityEditorControl
    {
        public Label Label { get; set; }
        public Control Control { get; set; }
        public int Priority { get; set; }
    }

    public class ComboItem<TValue>
    {
        public string Display { get; set; }
        public TValue value { get; set; }
    }

}
