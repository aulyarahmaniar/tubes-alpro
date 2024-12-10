using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tubes_alpro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label2_Click_1(object sender, EventArgs e)
        {
            START form1 = new START(); // Buat instance Form1
            form1.Show(); // Tampilkan Form1
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MENU form2 = new MENU();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
