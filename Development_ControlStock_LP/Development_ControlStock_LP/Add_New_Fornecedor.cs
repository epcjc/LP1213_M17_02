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
            try
            {
                this.tB_FornecedorTableAdapter.Insert(this.textBox1.Text, Convert.ToInt32(this.textBox2.Text), this.textBox3.Text);
                MessageBox.Show("Inserido novo cliente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a inserir");
            }
            
        }

        private void Add_New_Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TB_Fornecedor' table. You can move, or remove it, as needed.
            this.tB_FornecedorTableAdapter.Fill(this.database1DataSet.TB_Fornecedor);
            // TODO: This line of code loads data into the 'database1DataSet.TB_Fornecedor' table. You can move, or remove it, as needed.
            this.tB_FornecedorTableAdapter.Fill(this.database1DataSet.TB_Fornecedor);
        
        }

        private void tB_FornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void tB_FornecedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
