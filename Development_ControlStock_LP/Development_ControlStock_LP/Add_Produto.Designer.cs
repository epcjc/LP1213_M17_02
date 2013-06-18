namespace Development_ControlStock_LP
{
    partial class Add_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Fornecedor = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.Label();
            this.Preco_Compra = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Criar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.database1DataSet = new Development_ControlStock_LP.Database1DataSet();
            this.tBFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_FornecedorTableAdapter = new Development_ControlStock_LP.Database1DataSetTableAdapters.TB_FornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSize = true;
            this.Fornecedor.Location = new System.Drawing.Point(41, 37);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(61, 13);
            this.Fornecedor.TabIndex = 0;
            this.Fornecedor.Text = "Fornecedor";
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Location = new System.Drawing.Point(41, 73);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(44, 13);
            this.Produto.TabIndex = 1;
            this.Produto.Text = "Produto";
            // 
            // Preco_Compra
            // 
            this.Preco_Compra.AutoSize = true;
            this.Preco_Compra.Location = new System.Drawing.Point(41, 105);
            this.Preco_Compra.Name = "Preco_Compra";
            this.Preco_Compra.Size = new System.Drawing.Size(77, 13);
            this.Preco_Compra.TabIndex = 2;
            this.Preco_Compra.Text = "Preco_Compra";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(41, 142);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 3;
            this.Quantidade.Text = "Quantidade";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBFornecedorBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Criar
            // 
            this.Criar.Location = new System.Drawing.Point(44, 205);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(75, 23);
            this.Criar.TabIndex = 8;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(244, 205);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(75, 23);
            this.Menu.TabIndex = 9;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBFornecedorBindingSource
            // 
            this.tBFornecedorBindingSource.DataMember = "TB_Fornecedor";
            this.tBFornecedorBindingSource.DataSource = this.database1DataSet;
            // 
            // tB_FornecedorTableAdapter
            // 
            this.tB_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 240);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Preco_Compra);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.Fornecedor);
            this.Name = "Add_Produto";
            this.Text = "Add_Produto";
            this.Load += new System.EventHandler(this.Add_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fornecedor;
        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.Label Preco_Compra;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button Menu;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tBFornecedorBindingSource;
        private Database1DataSetTableAdapters.TB_FornecedorTableAdapter tB_FornecedorTableAdapter;
    }
}