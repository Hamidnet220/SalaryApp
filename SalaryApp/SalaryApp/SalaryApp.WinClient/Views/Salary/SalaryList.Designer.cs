namespace SalaryApp.WinClient.Views.Salary
{
    partial class SalaryList
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
            this.TopButtonsPanel = new System.Windows.Forms.Panel();
            this.FinalApprov = new System.Windows.Forms.Button();
            this.CreatePayrollFiles = new System.Windows.Forms.Button();
            this.CreateTaxFiles = new System.Windows.Forms.Button();
            this.CreateInsuranceFiles = new System.Windows.Forms.Button();
            this.CreatePayFile = new System.Windows.Forms.Button();
            this.EmployeesList = new System.Windows.Forms.Button();
            this.TopButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopButtonsPanel
            // 
            this.TopButtonsPanel.Controls.Add(this.FinalApprov);
            this.TopButtonsPanel.Controls.Add(this.CreatePayrollFiles);
            this.TopButtonsPanel.Controls.Add(this.CreateTaxFiles);
            this.TopButtonsPanel.Controls.Add(this.CreateInsuranceFiles);
            this.TopButtonsPanel.Controls.Add(this.CreatePayFile);
            this.TopButtonsPanel.Controls.Add(this.EmployeesList);
            this.TopButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.TopButtonsPanel.Name = "TopButtonsPanel";
            this.TopButtonsPanel.Size = new System.Drawing.Size(800, 51);
            this.TopButtonsPanel.TabIndex = 0;
            // 
            // FinalApprov
            // 
            this.FinalApprov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalApprov.Location = new System.Drawing.Point(51, 12);
            this.FinalApprov.Name = "FinalApprov";
            this.FinalApprov.Size = new System.Drawing.Size(108, 23);
            this.FinalApprov.TabIndex = 0;
            this.FinalApprov.Text = "تایید نهایی لیست";
            this.FinalApprov.UseVisualStyleBackColor = true;
            // 
            // CreatePayrollFiles
            // 
            this.CreatePayrollFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatePayrollFiles.Location = new System.Drawing.Point(165, 12);
            this.CreatePayrollFiles.Name = "CreatePayrollFiles";
            this.CreatePayrollFiles.Size = new System.Drawing.Size(146, 23);
            this.CreatePayrollFiles.TabIndex = 0;
            this.CreatePayrollFiles.Text = "ایجاد فیش های حقوقی";
            this.CreatePayrollFiles.UseVisualStyleBackColor = true;
            // 
            // CreateTaxFiles
            // 
            this.CreateTaxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTaxFiles.Location = new System.Drawing.Point(317, 12);
            this.CreateTaxFiles.Name = "CreateTaxFiles";
            this.CreateTaxFiles.Size = new System.Drawing.Size(108, 23);
            this.CreateTaxFiles.TabIndex = 0;
            this.CreateTaxFiles.Text = "ایجاد فایل مالیات";
            this.CreateTaxFiles.UseVisualStyleBackColor = true;
            // 
            // CreateInsuranceFiles
            // 
            this.CreateInsuranceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateInsuranceFiles.Location = new System.Drawing.Point(431, 12);
            this.CreateInsuranceFiles.Name = "CreateInsuranceFiles";
            this.CreateInsuranceFiles.Size = new System.Drawing.Size(108, 23);
            this.CreateInsuranceFiles.TabIndex = 0;
            this.CreateInsuranceFiles.Text = "ایجاد فایل بیمه";
            this.CreateInsuranceFiles.UseVisualStyleBackColor = true;
            // 
            // CreatePayFile
            // 
            this.CreatePayFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatePayFile.Location = new System.Drawing.Point(545, 12);
            this.CreatePayFile.Name = "CreatePayFile";
            this.CreatePayFile.Size = new System.Drawing.Size(108, 23);
            this.CreatePayFile.TabIndex = 0;
            this.CreatePayFile.Text = "ایجاد فایل پرداخت";
            this.CreatePayFile.UseVisualStyleBackColor = true;
            // 
            // EmployeesList
            // 
            this.EmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesList.Location = new System.Drawing.Point(659, 12);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(108, 23);
            this.EmployeesList.TabIndex = 0;
            this.EmployeesList.Text = "لیست پرسنل";
            this.EmployeesList.UseVisualStyleBackColor = true;
            // 
            // SalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopButtonsPanel);
            this.Name = "SalaryList";
            this.Text = "SalaryList";
            this.TopButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopButtonsPanel;
        private System.Windows.Forms.Button FinalApprov;
        private System.Windows.Forms.Button CreatePayrollFiles;
        private System.Windows.Forms.Button CreateTaxFiles;
        private System.Windows.Forms.Button CreateInsuranceFiles;
        private System.Windows.Forms.Button CreatePayFile;
        private System.Windows.Forms.Button EmployeesList;
    }
}