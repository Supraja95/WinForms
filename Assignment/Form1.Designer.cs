using System;
using System.Windows.Forms;

namespace Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGetEmployees = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCreateEmployee = new System.Windows.Forms.Button();
            this.LblEmpID = new System.Windows.Forms.Label();
            this.BtnUpdateEmployee = new System.Windows.Forms.Button();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.EmpName = new System.Windows.Forms.Label();
            this.LblEmpLastName = new System.Windows.Forms.Label();
            this.LblEmailID = new System.Windows.Forms.Label();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.TxtEmpFName = new System.Windows.Forms.TextBox();
            this.TxtEmpLName = new System.Windows.Forms.TextBox();
            this.TxtEmpEmailID = new System.Windows.Forms.TextBox();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.BtnGetAllEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetEmployees
            // 
            this.BtnGetEmployees.Location = new System.Drawing.Point(742, 35);
            this.BtnGetEmployees.Name = "BtnGetEmployees";
            this.BtnGetEmployees.Size = new System.Drawing.Size(173, 34);
            this.BtnGetEmployees.TabIndex = 0;
            this.BtnGetEmployees.Text = "Get Employees";
            this.BtnGetEmployees.UseVisualStyleBackColor = true;
            this.BtnGetEmployees.Click += new System.EventHandler(this.BtnGetEmployees_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(930, 338);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnCreateEmployee
            // 
            this.BtnCreateEmployee.Location = new System.Drawing.Point(971, 35);
            this.BtnCreateEmployee.Name = "BtnCreateEmployee";
            this.BtnCreateEmployee.Size = new System.Drawing.Size(171, 34);
            this.BtnCreateEmployee.TabIndex = 2;
            this.BtnCreateEmployee.Text = "Create Employee";
            this.BtnCreateEmployee.UseVisualStyleBackColor = true;
            this.BtnCreateEmployee.Click += new System.EventHandler(this.BtnCreateEmployee_Click_1Async);
            // 
            // LblEmpID
            // 
            this.LblEmpID.AutoSize = true;
            this.LblEmpID.Location = new System.Drawing.Point(84, 44);
            this.LblEmpID.Name = "LblEmpID";
            this.LblEmpID.Size = new System.Drawing.Size(108, 25);
            this.LblEmpID.TabIndex = 3;
            this.LblEmpID.Text = "EmployeeID";
            // 
            // BtnUpdateEmployee
            // 
            this.BtnUpdateEmployee.Location = new System.Drawing.Point(742, 104);
            this.BtnUpdateEmployee.Name = "BtnUpdateEmployee";
            this.BtnUpdateEmployee.Size = new System.Drawing.Size(173, 34);
            this.BtnUpdateEmployee.TabIndex = 4;
            this.BtnUpdateEmployee.Text = "Update Employee";
            this.BtnUpdateEmployee.UseVisualStyleBackColor = true;
            this.BtnUpdateEmployee.Click += new System.EventHandler(this.BtnUpdateEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(971, 104);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(171, 34);
            this.BtnDeleteEmployee.TabIndex = 5;
            this.BtnDeleteEmployee.Text = "DeleteEmployee";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // EmpName
            // 
            this.EmpName.AutoSize = true;
            this.EmpName.Location = new System.Drawing.Point(84, 113);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(137, 25);
            this.EmpName.TabIndex = 6;
            this.EmpName.Text = "EmployeeName";
            this.EmpName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblEmpLastName
            // 
            this.LblEmpLastName.AutoSize = true;
            this.LblEmpLastName.Location = new System.Drawing.Point(84, 192);
            this.LblEmpLastName.Name = "LblEmpLastName";
            this.LblEmpLastName.Size = new System.Drawing.Size(168, 25);
            this.LblEmpLastName.TabIndex = 7;
            this.LblEmpLastName.Text = "EmployeeLastName";
            // 
            // LblEmailID
            // 
            this.LblEmailID.AutoSize = true;
            this.LblEmailID.Location = new System.Drawing.Point(84, 288);
            this.LblEmailID.Name = "LblEmailID";
            this.LblEmailID.Size = new System.Drawing.Size(150, 25);
            this.LblEmailID.TabIndex = 8;
            this.LblEmailID.Text = "EmployeeEmailID";
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.Location = new System.Drawing.Point(308, 38);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(150, 31);
            this.TxtEmpID.TabIndex = 9;
            // 
            // TxtEmpFName
            // 
            this.TxtEmpFName.Location = new System.Drawing.Point(308, 107);
            this.TxtEmpFName.Name = "TxtEmpFName";
            this.TxtEmpFName.Size = new System.Drawing.Size(150, 31);
            this.TxtEmpFName.TabIndex = 10;
            // 
            // TxtEmpLName
            // 
            this.TxtEmpLName.Location = new System.Drawing.Point(308, 192);
            this.TxtEmpLName.Name = "TxtEmpLName";
            this.TxtEmpLName.Size = new System.Drawing.Size(150, 31);
            this.TxtEmpLName.TabIndex = 11;
            // 
            // TxtEmpEmailID
            // 
            this.TxtEmpEmailID.Location = new System.Drawing.Point(308, 282);
            this.TxtEmpEmailID.Name = "TxtEmpEmailID";
            this.TxtEmpEmailID.Size = new System.Drawing.Size(150, 31);
            this.TxtEmpEmailID.TabIndex = 12;
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Location = new System.Drawing.Point(742, 266);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(331, 68);
            this.BtnClearAll.TabIndex = 13;
            this.BtnClearAll.Text = "Clear All";
            this.BtnClearAll.UseVisualStyleBackColor = true;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // BtnGetAllEmployees
            // 
            this.BtnGetAllEmployees.Location = new System.Drawing.Point(742, 176);
            this.BtnGetAllEmployees.Name = "BtnGetAllEmployees";
            this.BtnGetAllEmployees.Size = new System.Drawing.Size(331, 62);
            this.BtnGetAllEmployees.TabIndex = 14;
            this.BtnGetAllEmployees.Text = "Get All Employees";
            this.BtnGetAllEmployees.UseVisualStyleBackColor = true;
            this.BtnGetAllEmployees.Click += new System.EventHandler(this.BtnGetAllEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 725);
            this.Controls.Add(this.BtnGetAllEmployees);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.TxtEmpEmailID);
            this.Controls.Add(this.TxtEmpLName);
            this.Controls.Add(this.TxtEmpFName);
            this.Controls.Add(this.TxtEmpID);
            this.Controls.Add(this.LblEmailID);
            this.Controls.Add(this.LblEmpLastName);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnUpdateEmployee);
            this.Controls.Add(this.LblEmpID);
            this.Controls.Add(this.BtnCreateEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGetEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.Button BtnGetEmployees;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCreateEmployee;
        private System.Windows.Forms.Label LblEmpID;
        private System.Windows.Forms.Button BtnUpdateEmployee;
        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.Label EmpName;
        private System.Windows.Forms.Label LblEmpLastName;
        private System.Windows.Forms.Label LblEmailID;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.TextBox TxtEmpFName;
        private System.Windows.Forms.TextBox TxtEmpLName;
        private System.Windows.Forms.TextBox TxtEmpEmailID;
        private Button BtnClearAll;
        private Button BtnGetAllEmployees;
    }
}
