using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" boton de aceptar", " Mensaje Aceptar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" botones Aceptar y Cancelar", " Mensaje OKCanccel", MessageBoxButtons.OKCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" botones Sí, No y Cancelar", " Mensaje YesNoCanccel", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" boton Aceptar", " Mensaje Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
