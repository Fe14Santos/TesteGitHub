namespace BibliotecaMonteiroLobato
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lbxResultadoPesquisa = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.rbtTombo = new System.Windows.Forms.RadioButton();
            this.rbtAutor = new System.Windows.Forms.RadioButton();
            this.buscar = new System.Windows.Forms.Button();
            this.tbxPesquisa = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario = new System.Windows.Forms.Label();
            this.lk_sair = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxResultadoPesquisa
            // 
            this.lbxResultadoPesquisa.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResultadoPesquisa.FormattingEnabled = true;
            this.lbxResultadoPesquisa.ItemHeight = 20;
            this.lbxResultadoPesquisa.Location = new System.Drawing.Point(19, 244);
            this.lbxResultadoPesquisa.Name = "lbxResultadoPesquisa";
            this.lbxResultadoPesquisa.Size = new System.Drawing.Size(667, 44);
            this.lbxResultadoPesquisa.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.rbtCodigo);
            this.groupBox1.Controls.Add(this.rbtNome);
            this.groupBox1.Controls.Add(this.rbtTombo);
            this.groupBox1.Controls.Add(this.rbtAutor);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.tbxPesquisa);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Livro por";
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(6, 19);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(67, 28);
            this.rbtCodigo.TabIndex = 10;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Código";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Location = new System.Drawing.Point(137, 19);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(61, 28);
            this.rbtNome.TabIndex = 7;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // rbtTombo
            // 
            this.rbtTombo.AutoSize = true;
            this.rbtTombo.Location = new System.Drawing.Point(478, 19);
            this.rbtTombo.Name = "rbtTombo";
            this.rbtTombo.Size = new System.Drawing.Size(67, 28);
            this.rbtTombo.TabIndex = 9;
            this.rbtTombo.TabStop = true;
            this.rbtTombo.Text = "Tombo";
            this.rbtTombo.UseVisualStyleBackColor = true;
            // 
            // rbtAutor
            // 
            this.rbtAutor.AutoSize = true;
            this.rbtAutor.Location = new System.Drawing.Point(299, 20);
            this.rbtAutor.Name = "rbtAutor";
            this.rbtAutor.Size = new System.Drawing.Size(60, 28);
            this.rbtAutor.TabIndex = 8;
            this.rbtAutor.TabStop = true;
            this.rbtAutor.Text = "Autor";
            this.rbtAutor.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.Tomato;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscar.Location = new System.Drawing.Point(568, 53);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(89, 26);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // tbxPesquisa
            // 
            this.tbxPesquisa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPesquisa.Location = new System.Drawing.Point(6, 53);
            this.tbxPesquisa.Name = "tbxPesquisa";
            this.tbxPesquisa.Size = new System.Drawing.Size(557, 26);
            this.tbxPesquisa.TabIndex = 3;
            this.tbxPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPesquisa_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Pronto";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "Versão ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F);
            this.label1.Location = new System.Drawing.Point(160, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca Monteiro Lobato";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 57);
            this.panel1.TabIndex = 13;
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(130, 28);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.abrirToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(64, 28);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.emprestimoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 32);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emprestimoToolStripMenuItem
            // 
            this.emprestimoToolStripMenuItem.Name = "emprestimoToolStripMenuItem";
            this.emprestimoToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.emprestimoToolStripMenuItem.Text = "Emprestimo";
            this.emprestimoToolStripMenuItem.Click += new System.EventHandler(this.emprestimoToolStripMenuItem_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.Transparent;
            this.usuario.Font = new System.Drawing.Font("Agency FB", 16F);
            this.usuario.Location = new System.Drawing.Point(468, 35);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(41, 26);
            this.usuario.TabIndex = 18;
            this.usuario.Text = "Olá, ";
            // 
            // lk_sair
            // 
            this.lk_sair.AutoSize = true;
            this.lk_sair.BackColor = System.Drawing.Color.Transparent;
            this.lk_sair.Enabled = false;
            this.lk_sair.Location = new System.Drawing.Point(676, 42);
            this.lk_sair.Name = "lk_sair";
            this.lk_sair.Size = new System.Drawing.Size(25, 13);
            this.lk_sair.TabIndex = 19;
            this.lk_sair.TabStop = true;
            this.lk_sair.Text = "Sair";
            this.lk_sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_sair_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaMonteiroLobato.Properties.Resources.fundo71;
            this.ClientSize = new System.Drawing.Size(713, 669);
            this.Controls.Add(this.lk_sair);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.lbxResultadoPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Monteiro Lobato";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxResultadoPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtTombo;
        private System.Windows.Forms.RadioButton rbtAutor;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox tbxPesquisa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.LinkLabel lk_sair;
        private System.Windows.Forms.ToolStripMenuItem emprestimoToolStripMenuItem;
    }
}