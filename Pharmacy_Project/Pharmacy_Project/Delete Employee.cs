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
    public partial class Delete_Employee :Form
    {
        Employee emp= new Employee();

        public Delete_Employee( )
        {
            InitializeComponent ();
        }

        private void buttonDeleteEmp_Click( object sender, EventArgs e )
        {
            if (textBoxEmpDelete.Text != "")
            {

                emp.DeleteEmployee(Int32.Parse(textBoxEmpDelete.Text));
                MessageBox.Show("Employee Deleted", "Employee Delete Confirmation");
                textBoxEmpDelete.Text = "";
                dataGridViewDeleteEmp.DataSource = emp.GetEmployeeList();
            }

            else
            {
                MessageBox.Show("Please Enter Id");

            }
        }

        private void textBoxEmpDelete_TextChanged( object sender, EventArgs e )
        {

        }



        private void Delete_Employee_FormClosing( object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }

        private void dataGridViewDeleteEmp_CellContentDoubleClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void dataGridViewDeleteEmp_CellContextMenuStripChanged( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void Delete_Employee_Load( object sender, EventArgs e )
        {
            dataGridViewDeleteEmp.DataSource = emp.GetEmployeeList();
        }

        private void buttonBackDeleteEmp_Click( object sender, EventArgs e )
        {
            Employee_Info  emp= new Employee_Info();
            emp.Show();
            this.Hide();
        }
    }
}
