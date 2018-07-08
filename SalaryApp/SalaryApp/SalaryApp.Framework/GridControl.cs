using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalarApp.Framework;

namespace SalaryApp.Framework
{
    public sealed class GridControl<TEntity>:DataGridView where TEntity:class
    {
        private readonly IEnumerable<TEntity> entities;
        private BindingSource bindigSource; 

        public GridControl(IEnumerable<TEntity> entities)
        {
            DoubleBuffered = true;

            Dock = DockStyle.Fill;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            EditMode = DataGridViewEditMode.EditProgrammatically;
            AutoGenerateColumns = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

             this.entities = entities;
             
             SetDataSource(entities);
        }


        public void SetDataSource (IEnumerable<TEntity> entities)
        {
            bindigSource = new BindingSource {DataSource = entities};
            DataSource = bindigSource;
            ((Control) this).ResetBindings();
            
        }


        public void  AddColumn<TProperty>(string columnName,
            Expression<Func<TEntity, TProperty>> selector )
        {
            var visitor = new ExperssionHandler();
            var col = new DataGridViewTextBoxColumn
            {
                HeaderText = columnName,
                DataPropertyName = visitor.GetPropertyName(selector)
            };
            this.Columns.Add(col);
        }

        public void AddCheckBox(string columnName)
        {
            var checkBox = new DataGridViewCheckBoxColumn
            {
                HeaderText = columnName,
            };
           
           Columns.Add(checkBox);
           
        }

        public void ResetBindings()
        {
            bindigSource?.ResetBindings(true);
        }

        public void AddColumn(string columnName,string propetyName)
        {
            Columns.Add(new DataGridViewTextBoxColumn
            {

                HeaderText = columnName,
                DataPropertyName = propetyName
            });
        }

        public void RemoveCurrent()
        {
            bindigSource.RemoveCurrent();
            ((Control) this).ResetBindings();
        }

        public TEntity CurrentItem => (TEntity) bindigSource?.Current;
    }
}