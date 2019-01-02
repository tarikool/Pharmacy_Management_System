namespace Pharmacy_Project
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMedDelete = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeleteMedicine = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridDelete = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxMedDelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonDeleteMedicine);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataGridDelete);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 416);
            this.panel1.TabIndex = 48;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(81, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Enter ID";
            // 
            // textBoxMedDelete
            // 
            this.textBoxMedDelete.Location = new System.Drawing.Point(175, 69);
            this.textBoxMedDelete.Multiline = true;
            this.textBoxMedDelete.Name = "textBoxMedDelete";
            this.textBoxMedDelete.Size = new System.Drawing.Size(148, 27);
            this.textBoxMedDelete.TabIndex = 51;
            this.textBoxMedDelete.TextChanged += new System.EventHandler(this.textBox1Delete_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(223, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 49;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteMedicine
            // 
            this.buttonDeleteMedicine.AutoSize = true;
            this.buttonDeleteMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMedicine.ForeColor = System.Drawing.Color.Brown;
            this.buttonDeleteMedicine.Location = new System.Drawing.Point(74, 368);
            this.buttonDeleteMedicine.Name = "buttonDeleteMedicine";
            this.buttonDeleteMedicine.Size = new System.Drawing.Size(85, 30);
            this.buttonDeleteMedicine.TabIndex = 48;
            this.buttonDeleteMedicine.Text = "Delete";
            this.buttonDeleteMedicine.UseVisualStyleBackColor = true;
            this.buttonDeleteMedicine.Click += new System.EventHandler(this.buttonDeleteMedicine_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(23, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Select The Medicine To Delete";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridDelete
            // 
            this.dataGridDelete.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDelete.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridDelete.Location = new System.Drawing.Point(27, 102);
            this.dataGridDelete.Name = "dataGridDelete";
            this.dataGridDelete.Size = new System.Drawing.Size(358, 234);
            this.dataGridDelete.TabIndex = 46;
            this.dataGridDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDelete_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(-2, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = " © 2017 Pharmacy_Management_Project.  All rights reserved.";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_FormClosing);
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeleteMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMedDelete;
        private System.Windows.Forms.Label label3;
    }
}