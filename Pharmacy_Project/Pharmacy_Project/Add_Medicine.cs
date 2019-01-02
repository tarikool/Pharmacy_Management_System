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
    public partial class Add_Medicine : Form
    {
        private Medicine medicine = new Medicine();
        
        public Add_Medicine()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Main_Menu m = new Main_Menu ();
            m.Show ();
            this.Hide ();
        }

        private void Add_Medicine_FormClosing( object sender, FormClosingEventArgs e )
        {

            Application.Exit ();
        }

        private void Info_Panel_Paint( object sender, PaintEventArgs e )
        {

        }

        private void Add_Medicine_Load( object sender, EventArgs e )
        {

        }

        private void buttonSaveMedicine_Click( object sender, EventArgs e )
        {
            string mName = textBoxMName.Text;
            string mGName = textBoxGName.Text;
            Double mPrice = Convert.ToDouble(textBoxMPrice.Text);
            int mQuantity = Convert.ToInt32(textBoxMQuantity.Text);
           
            medicine.AddMedicine(mName,mGName,mPrice,mQuantity);

            MessageBox.Show("Medicine Added succesfully");
        }
    }
}
