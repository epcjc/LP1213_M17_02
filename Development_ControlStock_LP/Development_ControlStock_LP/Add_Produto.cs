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
    public partial class Add_Produto : Form
    {
        public Add_Produto()
        {
            InitializeComponent();
        }

        private void Add_Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TB_Fornecedor' table. You can move, or remove it, as needed.
            this.tB_FornecedorTableAdapter.Fill(this.database1DataSet.TB_Fornecedor);

        }
    }
}
