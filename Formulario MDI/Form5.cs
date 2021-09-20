using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class form5 : Form

    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");

        public form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "fernando" || txtpass.Text == "fernando12345")
            {

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("usuario o contraseña incorrecta", " Nose encontro usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form5_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception a)
            {
                MessageBox.Show("error por" + a.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string consulta = "select password,usuario from login where password ='" + txtpass.Text + "' and usuario = '" + txtusuario.Text + "';";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataReader leedb;
            leedb = comando.ExecuteReader();
            Boolean existereg = leedb.HasRows;
            if (existereg)
            {
                MessageBox.Show("bienvenido al sistema" + txtusuario.Text);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto trate de nuevo");
                return;
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
