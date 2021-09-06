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
    public partial class form5 : Form
       
    {
        public form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "fernando" || txt_contraseña.Text == "fernando12345")
            {

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
                MessageBox.Show(" Contraseña o nombre incorrecto");
           
               
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
