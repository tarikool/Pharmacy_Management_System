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
    public partial class Employee_Info :Form
    {
        
        Employee emp= new Employee();
        
        public Employee_Info( )
        {
            InitializeComponent ();
        }

        private void Employee_Info_Load( object sender, EventArgs e )
        {
            dataGridViewEmp.DataSource = emp.GetEmployeeList();
        }

        private void Employee_Info_FormClosing( object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }

        private void buttonUpdateEmp_Click( object sender, EventArgs e )
        {
            Update_Employee emp= new Update_Employee();
            emp.Show();
            this.Hide();
        }

        private void buttonBack_Click( object sender, EventArgs e )
        {
            Main_Menu main= new Main_Menu();
            main.Show();
            this.Hide();
        }

        private void dataGridViewMainMenu_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
      
        }

        private void buttonDeleteEmp_Click( object sender, EventArgs e )
        {
            Delete_Employee emp= new Delete_Employee();
            emp.Show();
            this.Hide();
        }
    }
}
