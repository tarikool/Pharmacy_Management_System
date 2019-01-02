namespace Pharmacy_Project
{
    partial class Employee_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdateEmp = new System.Windows.Forms.Button();
            this.buttonDeleteEmp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridViewEmp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxNameSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 461);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(12, 208);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(349, 158);
            this.dataGridViewEmp.TabIndex = 45;
            this.dataGridViewEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMainMenu_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(56, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Search for Employee\'s";
            // 
            // textBoxNameSearch
            // 
            this.textBoxNameSearch.Location = new System.Drawing.Point(162, 85);
            this.textBoxNameSearch.Multiline = true;
            this.textBoxNameSearch.Name = "textBoxNameSearch";
            this.textBoxNameSearch.Size = new System.Drawing.Size(148, 27);
            this.textBoxNameSearch.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name";
            // 
            // buttonUpdateEmp
            // 
            this.buttonUpdateEmp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateEmp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateEmp.Location = new System.Drawing.Point(411, 124);
            this.buttonUpdateEmp.Name = "buttonUpdateEmp";
            this.buttonUpdateEmp.Size = new System.Drawing.Size(107, 51);
            this.buttonUpdateEmp.TabIndex = 24;
            this.buttonUpdateEmp.Text = "Update Employee";
            this.buttonUpdateEmp.UseVisualStyleBackColor = false;
            this.buttonUpdateEmp.Click += new System.EventHandler(this.buttonUpdateEmp_Click);
            // 
            // buttonDeleteEmp
            // 
            this.buttonDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteEmp.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteEmp.Location = new System.Drawing.Point(411, 214);
            this.buttonDeleteEmp.Name = "buttonDeleteEmp";
            this.buttonDeleteEmp.Size = new System.Drawing.Size(107, 56);
            this.buttonDeleteEmp.TabIndex = 30;
            this.buttonDeleteEmp.Text = "Delete Employee";
            this.buttonDeleteEmp.UseVisualStyleBackColor = true;
            this.buttonDeleteEmp.Click += new System.EventHandler(this.buttonDeleteEmp_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Crimson;
            this.buttonBack.Location = new System.Drawing.Point(423, 325);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 30);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(411, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 51);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Employee_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteEmp);
            this.Controls.Add(this.buttonUpdateEmp);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Info";
            this.Text = "Employee_Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_Info_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdateEmp;
        private System.Windows.Forms.Button buttonDeleteEmp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
    }
}