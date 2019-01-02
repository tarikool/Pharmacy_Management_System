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
    public partial class Update_Medicine : Form
    {
        int i;
        Medicine medicine=new Medicine();

        public Update_Medicine()
        {
            InitializeComponent();
        }

        private void label8_Click( object sender, EventArgs e )
        {

        }

        private void label7_Click( object sender, EventArgs e )
        {

        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void label5_Click( object sender, EventArgs e )
        {

        }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void label4_Click( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            Main_Menu m = new Main_Menu ();
            m.Show ();
            this.Hide ();
        }

        private void Update_Medicine_FormClosing( object sender, FormClosingEventArgs e )
        {
            Application.Exit ();
        }

        private void Update_Medicine_Load( object sender, EventArgs e )
        {
            dataGridViewMedicine.DataSource = medicine.GetMedicineList();
        }

        private void dataGridViewMedicine_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            i = (int) dataGridViewMedicine.Rows[( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells[0].Value;
            textBoxMName.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [1].Value.ToString ();
            textBoxMGName.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [2].Value.ToString ();
            textBoxMPrice.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [3].Value.ToString ();
            textBoxMQuantity.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [4].Value.ToString ();
            textBoxMedicineId.Text = Convert.ToString(i);

        }

        private void buttonBack_Click( object sender, EventArgs e )
        {
            Main_Menu mainMenu = new Main_Menu();
            this.Hide();
            mainMenu.Show();
        }

        private void buttonMedicineUpdate_Click( object sender, EventArgs e )
        {
            
            medicine.UpdateMedicine(Convert.ToInt32(textBoxMedicineId.Text),Convert.ToDouble(textBoxMPrice.Text),Convert.ToInt32(textBoxMQuantity.Text));
            MessageBox.Show(textBoxMName.Text + " Information Updated");
            dataGridViewMedicine.DataSource = medicine.GetMedicineList();
        }

        private void dataGridViewMedicine_CellContentDoubleClick( object sender, DataGridViewCellEventArgs e )
        {

            i = (int) dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [0].Value;
            textBoxMName.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [1].Value.ToString ();
            textBoxMGName.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [2].Value.ToString ();
            textBoxMPrice.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [3].Value.ToString ();
            textBoxMQuantity.Text = dataGridViewMedicine.Rows [( dataGridViewMedicine.SelectedCells [0].RowIndex )].Cells [4].Value.ToString ();
            textBoxMedicineId.Text = Convert.ToString (i);
        }

       
    }
}
