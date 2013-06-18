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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Add_Compra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TB_ComprasDetalhes' table. You can move, or remove it, as needed.
            this.tB_ComprasDetalhesTableAdapter.Fill(this.database1DataSet.TB_ComprasDetalhes);
            // TODO: This line of code loads data into the 'database1DataSet.TB_Produto' table. You can move, or remove it, as needed.
            this.tB_ProdutoTableAdapter.Fill(this.database1DataSet.TB_Produto);

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void tB_ProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_ProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Criar_Click(object sender, EventArgs e)
        {
            this.tB_ComprasDetalhesTableAdapter.Insert(Convert.ToInt16(this.comboBox1.Text), this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text, this.textBox6.Text);
        }
    }
}
