namespace Development_ControlStock_LP
{
    partial class Compra
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
            this.Produto = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.Preco_Unidade = new System.Windows.Forms.Label();
            this.Preco_sem_IVA = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Criar = new System.Windows.Forms.Button();
            this.database1DataSet = new Development_ControlStock_LP.Database1DataSet();
            this.tB_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ProdutoTableAdapter = new Development_ControlStock_LP.Database1DataSetTableAdapters.TB_ProdutoTableAdapter();
            this.tableAdapterManager = new Development_ControlStock_LP.Database1DataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tB_ComprasDetalhesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ComprasDetalhesTableAdapter = new Development_ControlStock_LP.Database1DataSetTableAdapters.TB_ComprasDetalhesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_ComprasDetalhesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Location = new System.Drawing.Point(42, 29);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(44, 13);
            this.Produto.TabIndex = 0;
            this.Produto.Text = "Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(42, 58);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 1;
            this.Quantidade.Text = "Quantidade";
            // 
            // Preco_Unidade
            // 
            this.Preco_Unidade.AutoSize = true;
            this.Preco_Unidade.Location = new System.Drawing.Point(42, 89);
            this.Preco_Unidade.Name = "Preco_Unidade";
            this.Preco_Unidade.Size = new System.Drawing.Size(78, 13);
            this.Preco_Unidade.TabIndex = 2;
            this.Preco_Unidade.Text = "Preço Unidade";
            // 
            // Preco_sem_IVA
            // 
            this.Preco_sem_IVA.AutoSize = true;
            this.Preco_sem_IVA.Location = new System.Drawing.Point(42, 119);
            this.Preco_sem_IVA.Name = "Preco_sem_IVA";
            this.Preco_sem_IVA.Size = new System.Drawing.Size(79, 13);
            this.Preco_sem_IVA.TabIndex = 3;
            this.Preco_sem_IVA.Text = "Preço Sem IVA";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(42, 151);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 4;
            this.Total.Text = "Total";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(45, 183);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 5;
            this.Data.Text = "Data";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(150, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(236, 223);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Menu";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Criar
            // 
            this.Criar.Location = new System.Drawing.Point(12, 223);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(75, 23);
            this.Criar.TabIndex = 13;
            this.Criar.Text = "Adicionar";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_ProdutoBindingSource
            // 
            this.tB_ProdutoBindingSource.DataMember = "TB_Produto";
            this.tB_ProdutoBindingSource.DataSource = this.database1DataSet;
            // 
            // tB_ProdutoTableAdapter
            // 
            this.tB_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_ComprasDetalhesTableAdapter = this.tB_ComprasDetalhesTableAdapter;
            this.tableAdapterManager.TB_FornecedorTableAdapter = null;
            this.tableAdapterManager.TB_ProdutoTableAdapter = this.tB_ProdutoTableAdapter;
            this.tableAdapterManager.TB_UtilizadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Development_ControlStock_LP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tB_ProdutoBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "ID";
            // 
            // tB_ComprasDetalhesBindingSource
            // 
            this.tB_ComprasDetalhesBindingSource.DataMember = "TB_ComprasDetalhes";
            this.tB_ComprasDetalhesBindingSource.DataSource = this.database1DataSet;
            // 
            // tB_ComprasDetalhesTableAdapter
            // 
            this.tB_ComprasDetalhesTableAdapter.ClearBeforeFill = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 254);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Preco_sem_IVA);
            this.Controls.Add(this.Preco_Unidade);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Produto);
            this.MinimizeBox = false;
            this.Name = "Compra";
            this.Text = "Adicionar_Compra";
            this.Load += new System.EventHandler(this.Add_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_ComprasDetalhesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Label Preco_Unidade;
        private System.Windows.Forms.Label Preco_sem_IVA;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Criar;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tB_ProdutoBindingSource;
        private Database1DataSetTableAdapters.TB_ProdutoTableAdapter tB_ProdutoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSetTableAdapters.TB_ComprasDetalhesTableAdapter tB_ComprasDetalhesTableAdapter;
        private System.Windows.Forms.BindingSource tB_ComprasDetalhesBindingSource;
    }
}