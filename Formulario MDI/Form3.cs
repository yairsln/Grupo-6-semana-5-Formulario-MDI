using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Formulario_MDI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader archivo = new StreamReader("c:\\ayuda.txt"); 
            string linea = "";
            ArrayList contenido = new ArrayList();
            while (linea!= null)
            {
                linea = archivo.ReadLine();
                if (linea!=null)
                {
                    contenido.Add(linea);
                    textBox1.Text = linea;
                
                }
                archivo.Close();
            } textBox1.Text = "";
            foreach (string linea_mostrar in contenido)
            {
                textBox1.Text = textBox1.Text + linea_mostrar + "Strings.Chr(13)";
            
            }
        }  


           

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

