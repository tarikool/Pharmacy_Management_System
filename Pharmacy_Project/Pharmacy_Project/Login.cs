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
using Data_Access_Layer;

namespace Pharmacy_Project
{
    public partial class Login : Form
    {
        private Employee employee = new Employee();

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Pharmacy_ContextDataContext pharmacyContext = new Pharmacy_ContextDataContext();
            string empName = textBoxEmployeeName.Text;
            string empPassword = textBoxEmployeePassword.Text;
            object list = employee.GetEmployee(empName);
            if (empName != "")
            {
                if (empPassword != "")
                {
                    var x = from a in pharmacyContext.Employee_Infos
                        where a.Employee_Name == empName && a.Password == empPassword
                        select a;
                    if (x.Any())
                    {
                        Main_Menu m1 = new Main_Menu();
                        m1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Not Matched", "Incorrect Information");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Password", "No Password");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Name", "No Employee Name");

            }

            /*object obj = employee.GetEmployee(empName);*/
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}