namespace Pharmacy_Project
{
    partial class Delete_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Employee));
            this.buttonDeleteEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmpDelete = new System.Windows.Forms.TextBox();
            this.dataGridViewDeleteEmp = new System.Windows.Forms.DataGridView();
            this.buttonBackDeleteEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteEmp
            // 
            this.buttonDeleteEmp.AutoSize = true;
            this.buttonDeleteEmp.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteEmp.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonDeleteEmp.Location = new System.Drawing.Point(89, 304);
            this.buttonDeleteEmp.Name = "buttonDeleteEmp";
            this.buttonDeleteEmp.Size = new System.Drawing.Size(88, 30);
            this.buttonDeleteEmp.TabIndex = 43;
            this.buttonDeleteEmp.Text = "Delete";
            this.buttonDeleteEmp.UseVisualStyleBackColor = false;
            this.buttonDeleteEmp.Click += new System.EventHandler(this.buttonDeleteEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id";
            // 
            // textBoxEmpDelete
            // 
            this.textBoxEmpDelete.Location = new System.Drawing.Point(162, 24);
            this.textBoxEmpDelete.Multiline = true;
            this.textBoxEmpDelete.Name = "textBoxEmpDelete";
            this.textBoxEmpDelete.Size = new System.Drawing.Size(148, 27);
            this.textBoxEmpDelete.TabIndex = 42;
            this.textBoxEmpDelete.TextChanged += new System.EventHandler(this.textBoxEmpDelete_TextChanged);
            // 
            // dataGridViewDeleteEmp
            // 
            this.dataGridViewDeleteEmp.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeleteEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDeleteEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeleteEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDeleteEmp.Location = new System.Drawing.Point(49, 78);
            this.dataGridViewDeleteEmp.Name = "dataGridViewDeleteEmp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeleteEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDeleteEmp.Size = new System.Drawing.Size(344, 167);
            this.dataGridViewDeleteEmp.TabIndex = 48;
            this.dataGridViewDeleteEmp.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeleteEmp_CellContentDoubleClick);
            this.dataGridViewDeleteEmp.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeleteEmp_CellContextMenuStripChanged);
            // 
            // buttonBackDeleteEmp
            // 
            this.buttonBackDeleteEmp.AutoSize = true;
            this.buttonBackDeleteEmp.BackColor = System.Drawing.Color.Black;
            this.buttonBackDeleteEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackDeleteEmp.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonBackDeleteEmp.Location = new System.Drawing.Point(248, 304);
            this.buttonBackDeleteEmp.Name = "buttonBackDeleteEmp";
            this.buttonBackDeleteEmp.Size = new System.Drawing.Size(88, 30);
            this.buttonBackDeleteEmp.TabIndex = 49;
            this.buttonBackDeleteEmp.Text = "Back";
            this.buttonBackDeleteEmp.UseVisualStyleBackColor = false;
            this.buttonBackDeleteEmp.Click += new System.EventHandler(this.buttonBackDeleteEmp_Click);
            // 
            // Delete_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(419, 359);
            this.Controls.Add(this.buttonBackDeleteEmp);
            this.Controls.Add(this.dataGridViewDeleteEmp);
            this.Controls.Add(this.buttonDeleteEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmpDelete);
            this.Name = "Delete_Employee";
            this.Text = "Delete_Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_Employee_FormClosing);
            this.Load += new System.EventHandler(this.Delete_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpDelete;
        private System.Windows.Forms.DataGridView dataGridViewDeleteEmp;
        private System.Windows.Forms.Button buttonBackDeleteEmp;
    }
}