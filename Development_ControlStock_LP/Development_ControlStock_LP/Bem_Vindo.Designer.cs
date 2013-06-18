namespace Development_ControlStock_LP
{
    partial class Bem_Vindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bem_Vindo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.forcedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 210);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 185);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(568, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clinica Dentária";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(485, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.inventarioToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarFornecedorToolStripMenuItem,
            this.editarFornecedorToolStripMenuItem,
            this.eliminarFornecedorToolStripMenuItem,
            this.forcedoresToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // criarFornecedorToolStripMenuItem
            // 
            this.criarFornecedorToolStripMenuItem.Name = "criarFornecedorToolStripMenuItem";
            this.criarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criarFornecedorToolStripMenuItem.Text = "Criar Novo";
            this.criarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.criarFornecedorToolStripMenuItem_Click);
            // 
            // editarFornecedorToolStripMenuItem
            // 
            this.editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            this.editarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarFornecedorToolStripMenuItem.Text = "Editar ";
            this.editarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.editarFornecedorToolStripMenuItem_Click);
            // 
            // eliminarFornecedorToolStripMenuItem
            // 
            this.eliminarFornecedorToolStripMenuItem.Name = "eliminarFornecedorToolStripMenuItem";
            this.eliminarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarFornecedorToolStripMenuItem.Text = "Eliminar";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarProdutosToolStripMenuItem,
            this.eliminarProdutosToolStripMenuItem,
            this.listarProdutosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.inventarioToolStripMenuItem.Text = "Compras";
            // 
            // adicionarProdutosToolStripMenuItem
            // 
            this.adicionarProdutosToolStripMenuItem.Name = "adicionarProdutosToolStripMenuItem";
            this.adicionarProdutosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.adicionarProdutosToolStripMenuItem.Text = "Adicionar Compra";
            this.adicionarProdutosToolStripMenuItem.Click += new System.EventHandler(this.adicionarProdutosToolStripMenuItem_Click);
            // 
            // eliminarProdutosToolStripMenuItem
            // 
            this.eliminarProdutosToolStripMenuItem.Name = "eliminarProdutosToolStripMenuItem";
            this.eliminarProdutosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eliminarProdutosToolStripMenuItem.Text = "Eliminar ";
            // 
            // listarProdutosToolStripMenuItem
            // 
            this.listarProdutosToolStripMenuItem.Name = "listarProdutosToolStripMenuItem";
            this.listarProdutosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listarProdutosToolStripMenuItem.Text = "Listar Compras";
            this.listarProdutosToolStripMenuItem.Click += new System.EventHandler(this.listarProdutosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirProdutoToolStripMenuItem,
            this.eliminarProdutoToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // lbDateTime
            // 
            this.lbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // forcedoresToolStripMenuItem
            // 
            this.forcedoresToolStripMenuItem.Name = "forcedoresToolStripMenuItem";
            this.forcedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forcedoresToolStripMenuItem.Text = "Forcedores";
            this.forcedoresToolStripMenuItem.Click += new System.EventHandler(this.forcedoresToolStripMenuItem_Click);
            // 
            // inserirProdutoToolStripMenuItem
            // 
            this.inserirProdutoToolStripMenuItem.Name = "inserirProdutoToolStripMenuItem";
            this.inserirProdutoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.inserirProdutoToolStripMenuItem.Text = "Inserir Produto";
            // 
            // eliminarProdutoToolStripMenuItem
            // 
            this.eliminarProdutoToolStripMenuItem.Name = "eliminarProdutoToolStripMenuItem";
            this.eliminarProdutoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eliminarProdutoToolStripMenuItem.Text = "Eliminar Produto";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listasToolStripMenuItem.Text = "Listar";
            // 
            // Bem_Vindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 210);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Bem_Vindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo";
            this.Load += new System.EventHandler(this.Bem_Vindo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel lbDateTime;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem forcedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;

    }
}