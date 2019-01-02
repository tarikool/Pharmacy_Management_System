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
    public partial class Main_Menu : Form
    {
        Medicine medicine=new Medicine();
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            Delete d = new Delete ();
            d.Show ();
            this.Hide ();
        }

        private void button3_Click( object sender, EventArgs e )
        {
            Add_Medicine m = new Add_Medicine();
            m.Show ();
            this.Hide ();
        }

        private void button2_Click( object sender, EventArgs e )
        {
            Update_Medicine u = new Update_Medicine ();
            u.Show();
            this.Hide();
        }

        private void button4_Click( object sender, EventArgs e )
        {
            Login l = new Login ();
            l.Show ();
            this.Hide ();
        }

        private void Main_Menu_FormClosing( object sender, FormClosingEventArgs e )
        {
            Application.Exit ();
        }

        private void label7_Click( object sender, EventArgs e )
        {

        }

        private void Main_Menu_Load( object sender, EventArgs e )
        {
            dataGridViewMainMenu.DataSource = medicine.GetMedicineList();
        }

        private void buttonEmployee_Click( object sender, EventArgs e )
        {
            Employee_Info emp = new Employee_Info();
            emp.Show();
            this.Hide();
        }
    }
}
