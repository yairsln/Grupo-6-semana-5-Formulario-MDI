using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este combo?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Comprar este combo?", " Confirmacion de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
