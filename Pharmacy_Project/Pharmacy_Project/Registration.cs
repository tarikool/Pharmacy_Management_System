using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Pharmacy_Project
{
    public partial class Registration : Form
    {
        private Employee employee = new Employee();
        public Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click( object sender, EventArgs e )
        {
            string eName = textBoxEmploeyeeName.Text;
            string ePassword = textBoxEmploeyeePassword.Text;
            string eConfirmPassword = textBoxEmploeyeeConfirmPassword.Text;
            string eBloodGroup = "";
            if ( comboBoxBloodGroup.SelectedIndex != -1 )
            {
                eBloodGroup = comboBoxBloodGroup.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show ("Please Select Your Blood Group");
            }
            string eGender = "";
            if (radioButtonMale.Checked)
            {
               eGender = "male";
            }
            else if ( radioButtonFemale.Checked )
            {
               eGender = "female";
            }
            else if(!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please Select Gender");
            }
            if (eName != "")
            {
                if ( ePassword != "" )
                {
                    if ( ePassword==eConfirmPassword )
                    {

                        employee.AddEmployee(eName,ePassword,eBloodGroup,eGender);
                    }
                    else
                    {
                        MessageBox.Show ("Please Enter Same Password");
                    }
                }
                else
                {
                    MessageBox.Show ("Please Enter Password");
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter Your Name");
            }
          

            

            employee.AddEmployee(eName,ePassword,eBloodGroup,eGender);
            MessageBox.Show("Successfully Regisytered");
            this.Hide();
            Login login = new Login();
            login.Show();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing( object sender, FormClosingEventArgs e )
        {

            Application.Exit ();
        }

        private void label5_Click( object sender, EventArgs e )
        {

        }

        private void pictureBox2_Click( object sender, EventArgs e )
        {

        }
    }
}
