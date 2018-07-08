namespace SalaryApp.WinClient.Views.Employees
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
            this.ButttonsPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.ButttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButttonsPanel
            // 
            this.ButttonsPanel.Controls.Add(this.DeleteButton);
            this.ButttonsPanel.Controls.Add(this.EditButton);
            this.ButttonsPanel.Controls.Add(this.NewButton);
            this.ButttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButttonsPanel.Location = new System.Drawing.Point(0, 294);
            this.ButttonsPanel.Name = "ButttonsPanel";
            this.ButttonsPanel.Size = new System.Drawing.Size(466, 43);
            this.ButttonsPanel.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(217, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(298, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "ویرایش";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Location = new System.Drawing.Point(379, 8);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "جدید";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 337);
            this.Controls.Add(this.ButttonsPanel);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.ButttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButttonsPanel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
    }
}