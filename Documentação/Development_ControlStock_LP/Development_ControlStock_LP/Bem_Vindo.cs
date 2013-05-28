﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Development_ControlStock_LP
{
    public partial class Bem_Vindo : Form
    {
        public Bem_Vindo()
        {
            InitializeComponent();
        }

        private void Bem_Vindo_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            sisDBADM test = new sisDBADM();

            if (test.Conectar())
            {
                MessageBox.Show("Ligou-se");
            }
            else
            {
                MessageBox.Show(" Não se Ligou");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datahora = DateTime.Now;
            lbDateTime.Text = "Data: " + datahora.ToShortDateString() + " Hora: " + datahora.ToLongTimeString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        }
}
