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
    public partial class Update_Employee : Form
    {
        private int i;
        private string empGender;
        private string bloodGroup;
        private Employee employee = new Employee();

        public Update_Employee()
        {
            InitializeComponent();
        }

        private void Info_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Employee_Info emp = new Employee_Info();
            emp.Show();
            this.Hide();
        }

        private void Update_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            dataGridUpdateEmployee.DataSource = employee.GetEmployeeList();
        }

        private void dataGridUpdateEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = (int) dataGridUpdateEmployee.Rows[(dataGridUpdateEmployee.SelectedCells[0].RowIndex)].Cells[0].Value;
            textBoxEmpName.Text = dataGridUpdateEmployee.Rows[(dataGridUpdateEmployee.SelectedCells[0].RowIndex)]
                .Cells[1].Value.ToString();
            textBoxUpdatePassword.Text = dataGridUpdateEmployee.Rows [( dataGridUpdateEmployee.SelectedCells [0].RowIndex )]
                .Cells [2].Value.ToString ();
           
            bloodGroup = dataGridUpdateEmployee.Rows[(dataGridUpdateEmployee.SelectedCells[0].RowIndex)].Cells[3].Value
                .ToString();
            empGender = dataGridUpdateEmployee.Rows[(dataGridUpdateEmployee.SelectedCells[0].RowIndex)].Cells[4].Value
                .ToString();
            if (empGender == "male")
            {

                radioButtonMale.Checked = true;
            }
            else if (empGender == "female")
            {
                radioButtonFemale.Checked = true;
            }
            comboBoxBloodGroup.SelectedItem = bloodGroup;
            /*textBoxEmpPassword.Text = dataGridUpdateEmployee.Rows [( dataGridUpdateEmployee.SelectedCells [0].RowIndex )].Cells [2].Value.ToString ();
            textBoxMPrice.Text = dataGridUpdateEmployee.Rows [( dataGridUpdateEmployee.SelectedCells [0].RowIndex )].Cells [3].Value.ToString ();
            textBoxMQuantity.Text = dataGridUpdateEmployee.Rows [( dataGridUpdateEmployee.SelectedCells [0].RowIndex )].Cells [4].Value.ToString ();
            textBoxMedicineId.Text = Convert.ToString (i);*/
        }

        private void buttonMedicineUpdate_Click( object sender, EventArgs e )
        {
            string eBloodGroup = "";
            if ( comboBoxBloodGroup.SelectedIndex != -1 )
            {
                eBloodGroup = comboBoxBloodGroup.SelectedItem.ToString ();

            }
            else
            {
                MessageBox.Show ("Please Select Your Blood Group");
            }
            string eGender = "";
            if ( radioButtonMale.Checked )
            {
                eGender = "male";
            }
            else if ( radioButtonFemale.Checked )
            {
                eGender = "female";
            }

            employee.UpdateEmployee(i, textBoxEmpName.Text, textBoxUpdatePassword.Text,eBloodGroup,eGender);
            MessageBox.Show (textBoxEmpName.Text + " Information Updated");
            dataGridUpdateEmployee.DataSource = employee.GetEmployeeList();
        }
    }
}