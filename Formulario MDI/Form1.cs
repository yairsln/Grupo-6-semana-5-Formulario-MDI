﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f2 = new AboutBox1();
            f2.ShowDialog();
        }
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        private void cuadroDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.ShowDialog();
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void heladosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
