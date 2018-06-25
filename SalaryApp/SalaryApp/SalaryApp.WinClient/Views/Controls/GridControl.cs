using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using SalaryApp.WinClient.Views.Employees;

namespace SalaryApp.WinClient.Views.Controls
{
    public class GridControl<TEntity>:DataGridView where TEntity:class
    {
        private IEnumerable<TEntity> entities;
        private BindingSource bindigSource; 

        public GridControl(IEnumerable<TEntity> entities)
        {
            //Boost up Performance 
            this.DoubleBuffered = true;

           //Start Styling DataGridView
            this.Dock = DockStyle.Fill;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.AutoGenerateColumns = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //End Styling DataGridView

             this.entities = entities;
             
             SetDataSource();
        }


        public void SetDataSource ()
        {
            bindigSource = new BindingSource();
            //bindig source to grid
            bindigSource.DataSource = entities;
            this.DataSource = bindigSource;
            this.bindigSource.ResetBindings(true);
            
        }


        //Add Column to DataGrid Method
        public  GridControl<TEntity> AddColumn<TProperty>(string columnName,
            Expression<Func<TEntity, TProperty>> selector)
        {
            var visitor = new ExperssionHandler();
            this.Columns.Add(new DataGridViewTextBoxColumn
            {

                HeaderText = columnName,
                DataPropertyName = visitor.GetPropertyName(selector)
            });

            return this;
        }

        public void ResetBindings()
        {
            bindigSource?.ResetBindings(true);
        }

        public void RemoveCurrent()
        {
            bindigSource.RemoveCurrent();
            bindigSource.ResetBindings(true);
        }

        public TEntity CurrentItem
        {
            get { return(TEntity) bindigSource?.Current; }
        }

    }
}