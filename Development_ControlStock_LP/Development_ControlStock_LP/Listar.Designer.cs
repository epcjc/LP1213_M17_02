namespace Development_ControlStock_LP
{
    partial class Listar
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
            this.database1DataSet = new Development_ControlStock_LP.Database1DataSet();
            this.tB_FornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_FornecedorTableAdapter = new Development_ControlStock_LP.Database1DataSetTableAdapters.TB_FornecedorTableAdapter();
            this.tableAdapterManager = new Development_ControlStock_LP.Database1DataSetTableAdapters.TableAdapterManager();
            this.tB_FornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FornecedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_FornecedorBindingSource
            // 
            this.tB_FornecedorBindingSource.DataMember = "TB_Fornecedor";
            this.tB_FornecedorBindingSource.DataSource = this.database1DataSet;
            // 
            // tB_FornecedorTableAdapter
            // 
            this.tB_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_ComprasDetalhesTableAdapter = null;
            this.tableAdapterManager.TB_ComprasTableAdapter = null;
            this.tableAdapterManager.TB_FornecedorTableAdapter = this.tB_FornecedorTableAdapter;
            this.tableAdapterManager.TB_ProdutoTableAdapter = null;
            this.tableAdapterManager.TB_UtilizadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Development_ControlStock_LP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_FornecedorDataGridView
            // 
            this.tB_FornecedorDataGridView.AutoGenerateColumns = false;
            this.tB_FornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_FornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tB_FornecedorDataGridView.DataSource = this.tB_FornecedorBindingSource;
            this.tB_FornecedorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_FornecedorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tB_FornecedorDataGridView.Name = "tB_FornecedorDataGridView";
            this.tB_FornecedorDataGridView.Size = new System.Drawing.Size(445, 125);
            this.tB_FornecedorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 125);
            this.Controls.Add(this.tB_FornecedorDataGridView);
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FornecedorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tB_FornecedorBindingSource;
        private Database1DataSetTableAdapters.TB_FornecedorTableAdapter tB_FornecedorTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tB_FornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}