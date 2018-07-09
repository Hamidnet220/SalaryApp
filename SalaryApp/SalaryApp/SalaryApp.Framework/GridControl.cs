using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalarApp.Framework;
using StructureMap.Diagnostics.TreeView;

namespace SalaryApp.Framework
{
    public class GridControl<TModel>
    {
        private DataGridView grid;
        private BindingSource bindigSource; 

        public GridControl(Control container)
        {
            grid=new DataGridView();
            container.Controls.Add(grid);

            grid.Dock = DockStyle.Fill;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.AutoGenerateColumns = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }


        public GridControl<TModel> SetDataSource (IEnumerable<TModel> dataSource)
        {
            bindigSource = new BindingSource {DataSource = dataSource};
            grid.DataSource = bindigSource;
            bindigSource.ResetBindings(true);

            return this;
        }


        public GridControl<TModel> AddTextBoxColumn<TProperty>(string columnName,
            Expression<Func<TModel, TProperty>> selector )
        {
            var propertyName = new ExperssionHandler().GetPropertyName(selector);
            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
               HeaderText = columnName,
               DataPropertyName = propertyName
            });

            return this;
        }

        public GridControl<TModel> AddCheckBox(string columnName)
        {
            var checkBox = new DataGridViewCheckBoxColumn
            {
                HeaderText = columnName,
            };

            grid.Columns.Add(checkBox);
            return this;

        }

        public void ResetBindings()
        {
            bindigSource?.ResetBindings(true);
        }

        public TModel CurrentItem
        {
            get { return (TModel)bindigSource?.Current; }
        }

        public void RemoveCurrent()
        {
            bindigSource.RemoveCurrent();
            ResetBindings();
        }

    }
}