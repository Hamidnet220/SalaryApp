namespace SalaryApp.WinClient.Views.SalaryDetails
{
    partial class List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalaculateAllEmp = new System.Windows.Forms.Button();
            this.CalaculateSelectEmp = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalaculateAllEmp);
            this.panel1.Controls.Add(this.CalaculateSelectEmp);
            this.panel1.Controls.Add(this.DeleteEmployee);
            this.panel1.Controls.Add(this.EditEmployee);
            this.panel1.Controls.Add(this.AddEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // CalaculateAllEmp
            // 
            this.CalaculateAllEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalaculateAllEmp.Location = new System.Drawing.Point(232, 12);
            this.CalaculateAllEmp.Name = "CalaculateAllEmp";
            this.CalaculateAllEmp.Size = new System.Drawing.Size(121, 23);
            this.CalaculateAllEmp.TabIndex = 0;
            this.CalaculateAllEmp.Text = "محاسبه حقوق همه";
            this.CalaculateAllEmp.UseVisualStyleBackColor = true;
            // 
            // CalaculateSelectEmp
            // 
            this.CalaculateSelectEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalaculateSelectEmp.Location = new System.Drawing.Point(359, 12);
            this.CalaculateSelectEmp.Name = "CalaculateSelectEmp";
            this.CalaculateSelectEmp.Size = new System.Drawing.Size(105, 23);
            this.CalaculateSelectEmp.TabIndex = 0;
            this.CalaculateSelectEmp.Text = "محاسبه حقوق";
            this.CalaculateSelectEmp.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEmployee.Location = new System.Drawing.Point(470, 12);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(105, 23);
            this.DeleteEmployee.TabIndex = 0;
            this.DeleteEmployee.Text = "حذف";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditEmployee.Location = new System.Drawing.Point(581, 12);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(105, 23);
            this.EditEmployee.TabIndex = 0;
            this.EditEmployee.Text = "ویرایش";
            this.EditEmployee.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee.Location = new System.Drawing.Point(692, 12);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(105, 23);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "اضافه کردن";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // SalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SalaryDetails";
            this.Text = "SalaryDetails";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button CalaculateAllEmp;
        private System.Windows.Forms.Button CalaculateSelectEmp;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button EditEmployee;
    }
}