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
    public partial class Add_New_Fornecedor : Form
    {
        public Add_New_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this..Insert(textBox1.Text, Convert.ToInt16(.SelectedValue), Convert.ToInt16(textBox2.Text));
        }

        private void Add_New_Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Pais' table. You can move, or remove it, as needed.
            //this..Fill(this..Pais);
        }
    }
}
