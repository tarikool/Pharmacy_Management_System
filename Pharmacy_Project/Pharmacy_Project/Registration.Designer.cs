namespace Pharmacy_Project
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.textBoxEmploeyeePassword = new System.Windows.Forms.TextBox();
            this.textBoxEmploeyeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmploeyeeConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmploeyeePassword
            // 
            this.textBoxEmploeyeePassword.Location = new System.Drawing.Point(229, 85);
            this.textBoxEmploeyeePassword.Multiline = true;
            this.textBoxEmploeyeePassword.Name = "textBoxEmploeyeePassword";
            this.textBoxEmploeyeePassword.Size = new System.Drawing.Size(148, 24);
            this.textBoxEmploeyeePassword.TabIndex = 9;
            // 
            // textBoxEmploeyeeName
            // 
            this.textBoxEmploeyeeName.Location = new System.Drawing.Point(229, 32);
            this.textBoxEmploeyeeName.Multiline = true;
            this.textBoxEmploeyeeName.Name = "textBoxEmploeyeeName";
            this.textBoxEmploeyeeName.Size = new System.Drawing.Size(148, 24);
            this.textBoxEmploeyeeName.TabIndex = 8;
            // 
            // textBoxEmploeyeeConfirmPassword
            // 
            this.textBoxEmploeyeeConfirmPassword.Location = new System.Drawing.Point(229, 138);
            this.textBoxEmploeyeeConfirmPassword.Multiline = true;
            this.textBoxEmploeyeeConfirmPassword.Name = "textBoxEmploeyeeConfirmPassword";
            this.textBoxEmploeyeeConfirmPassword.Size = new System.Drawing.Size(148, 24);
            this.textBoxEmploeyeeConfirmPassword.TabIndex = 11;
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToHome.Location = new System.Drawing.Point(300, 349);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(93, 31);
            this.buttonBackToHome.TabIndex = 12;
            this.buttonBackToHome.Text = "Back";
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(151, 349);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(84, 31);
            this.buttonSignUp.TabIndex = 13;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.IntegralHeight = false;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(229, 194);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(67, 21);
            this.comboBoxBloodGroup.TabIndex = 60;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButtonFemale.Location = new System.Drawing.Point(365, 251);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(70, 21);
            this.radioButtonFemale.TabIndex = 62;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMale.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButtonMale.Location = new System.Drawing.Point(229, 251);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 20);
            this.radioButtonMale.TabIndex = 61;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(24, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Employee Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(37, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Blood Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(56, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Gender ";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(501, 436);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.textBoxEmploeyeeConfirmPassword);
            this.Controls.Add(this.textBoxEmploeyeePassword);
            this.Controls.Add(this.textBoxEmploeyeeName);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmploeyeePassword;
        private System.Windows.Forms.TextBox textBoxEmploeyeeName;
        private System.Windows.Forms.TextBox textBoxEmploeyeeConfirmPassword;
        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}