using System;
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
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datahora = DateTime.Now;
            lbDateTime.Text = "Data: " + datahora.ToShortDateString() + " Hora: " + datahora.ToLongTimeString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
