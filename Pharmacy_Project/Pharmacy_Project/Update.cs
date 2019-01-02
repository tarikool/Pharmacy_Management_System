using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Project
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void Update_FormClosing( object sender, FormClosingEventArgs e )
        {

            Application.Exit ();
        }

        private void label1_Click( object sender, EventArgs e )
        {

        }
    }
}
