﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        //ieuhfioerhcoieruchureihfiuerhfuirhfiuerhfiuerfhuerhieruvhureivheirufvheiruvheriuvheruivheriuvhu//
        //rjnfierunicuermceriuncievwniweuvniuernviuenviuew//
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        //nuiwenciunreqiuciuqebciubqe//
        //niewnciuewqbciwb//
        //uiewhidubhewiufb//
        //idewnciuqebcoiu//
        private void cuadroDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
