namespace BibliotecaMonteiroLobato
{
    partial class CadastroLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivros));
            this.liv_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liv_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gen_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liv_tombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRAVARNOBANCOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importartxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_novo_registro = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.tbx_cod_barras = new System.Windows.Forms.TextBox();
            this.tbx_tombo = new System.Windows.Forms.TextBox();
            this.tbx_autor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_genero = new System.Windows.Forms.ComboBox();
            this.tbx_codigo = new System.Windows.Forms.TextBox();
            this.TbxNome = new System.Windows.Forms.TextBox();
            this.num_caracteres_nome = new System.Windows.Forms.Label();
            this.num_caracteres_autor = new System.Windows.Forms.Label();
            this.TooTipCrud = new System.Windows.Forms.ToolTip(this.components);
            this.tbx_Localiza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.p = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liv_nome
            // 
            this.liv_nome.HeaderText = "Nome";
            this.liv_nome.Name = "liv_nome";
            this.liv_nome.ReadOnly = true;
            this.liv_nome.Width = 250;
            // 
            // liv_autor
            // 
            this.liv_autor.HeaderText = "Autor";
            this.liv_autor.Name = "liv_autor";
            this.liv_autor.ReadOnly = true;
            this.liv_autor.Width = 115;
            // 
            // gen_nome
            // 
            this.gen_nome.HeaderText = "Gênero";
            this.gen_nome.Name = "gen_nome";
            this.gen_nome.ReadOnly = true;
            this.gen_nome.Width = 195;
            // 
            // liv_tombo
            // 
            this.liv_tombo.HeaderText = "Tombo";
            this.liv_tombo.Name = "liv_tombo";
            this.liv_tombo.ReadOnly = true;
            this.liv_tombo.Width = 60;
            // 
            // num
            // 
            this.num.HeaderText = "Nº";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tomato;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.liv_nome,
            this.liv_autor,
            this.gen_nome,
            this.liv_tombo});
            this.dataGridView1.Location = new System.Drawing.Point(29, 505);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(673, 152);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.gRAVARNOBANCOToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.exportaToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.aRQUIVOToolStripMenuItem.Font = new System.Drawing.Font("Agency FB", 14F);
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(64, 28);
            this.aRQUIVOToolStripMenuItem.Text = "Arquivo";
            // 
            // nOVOToolStripMenuItem
            // 
            this.nOVOToolStripMenuItem.Name = "nOVOToolStripMenuItem";
            this.nOVOToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.nOVOToolStripMenuItem.Text = "Novo";
            this.nOVOToolStripMenuItem.Click += new System.EventHandler(this.nOVOToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Enabled = false;
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // gRAVARNOBANCOToolStripMenuItem
            // 
            this.gRAVARNOBANCOToolStripMenuItem.Enabled = false;
            this.gRAVARNOBANCOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gRAVARNOBANCOToolStripMenuItem.Image")));
            this.gRAVARNOBANCOToolStripMenuItem.Name = "gRAVARNOBANCOToolStripMenuItem";
            this.gRAVARNOBANCOToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.gRAVARNOBANCOToolStripMenuItem.Text = "Grava no Banco";
            this.gRAVARNOBANCOToolStripMenuItem.Click += new System.EventHandler(this.gRAVARNOBANCOToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Enabled = false;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // exportaToolStripMenuItem
            // 
            this.exportaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivotxtToolStripMenuItem,
            this.importartxtToolStripMenuItem});
            this.exportaToolStripMenuItem.Name = "exportaToolStripMenuItem";
            this.exportaToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.exportaToolStripMenuItem.Text = "Exporta/Importar";
            // 
            // arquivotxtToolStripMenuItem
            // 
            this.arquivotxtToolStripMenuItem.Name = "arquivotxtToolStripMenuItem";
            this.arquivotxtToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.arquivotxtToolStripMenuItem.Text = "Exportar.txt";
            this.arquivotxtToolStripMenuItem.Click += new System.EventHandler(this.arquivotxtToolStripMenuItem_Click);
            // 
            // importartxtToolStripMenuItem
            // 
            this.importartxtToolStripMenuItem.Name = "importartxtToolStripMenuItem";
            this.importartxtToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.importartxtToolStripMenuItem.Text = "Importar.txt";
            this.importartxtToolStripMenuItem.Click += new System.EventHandler(this.importartxtToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sAIRToolStripMenuItem.Image")));
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.sAIRToolStripMenuItem.Text = "Sair";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem,
            this.vizualizaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 32);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizaçãoToolStripMenuItem
            // 
            this.vizualizaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem});
            this.vizualizaçãoToolStripMenuItem.Font = new System.Drawing.Font("Agency FB", 14F);
            this.vizualizaçãoToolStripMenuItem.Name = "vizualizaçãoToolStripMenuItem";
            this.vizualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.vizualizaçãoToolStripMenuItem.Text = "Visualização";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.livrosToolStripMenuItem.Text = "Todos os Livros ";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.btn_novo_registro);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Controls.Add(this.btn_atualizar);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_excluir);
            this.panel2.Location = new System.Drawing.Point(29, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 49);
            this.panel2.TabIndex = 37;
            // 
            // btn_novo_registro
            // 
            this.btn_novo_registro.BackColor = System.Drawing.Color.Tomato;
            this.btn_novo_registro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_novo_registro.BackgroundImage")));
            this.btn_novo_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_novo_registro.FlatAppearance.BorderSize = 0;
            this.btn_novo_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_registro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.btn_novo_registro.Location = new System.Drawing.Point(87, 4);
            this.btn_novo_registro.Name = "btn_novo_registro";
            this.btn_novo_registro.Size = new System.Drawing.Size(48, 43);
            this.btn_novo_registro.TabIndex = 24;
            this.TooTipCrud.SetToolTip(this.btn_novo_registro, "Adicionar novo livro");
            this.btn_novo_registro.UseVisualStyleBackColor = false;
            this.btn_novo_registro.Click += new System.EventHandler(this.tbn_novo_registro_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Tomato;
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.btn_salvar.Location = new System.Drawing.Point(417, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(48, 43);
            this.btn_salvar.TabIndex = 17;
            this.TooTipCrud.SetToolTip(this.btn_salvar, "Salvar no Banco de Dados");
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Tomato;
            this.btn_atualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.BackgroundImage")));
            this.btn_atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.btn_atualizar.Location = new System.Drawing.Point(197, 4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(48, 43);
            this.btn_atualizar.TabIndex = 20;
            this.TooTipCrud.SetToolTip(this.btn_atualizar, "Alterar informações de um registro");
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(527, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(48, 43);
            this.btn_cancelar.TabIndex = 18;
            this.TooTipCrud.SetToolTip(this.btn_cancelar, "Cancelar uma Operação");
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Tomato;
            this.btn_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir.BackgroundImage")));
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.btn_excluir.Location = new System.Drawing.Point(307, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(48, 43);
            this.btn_excluir.TabIndex = 19;
            this.TooTipCrud.SetToolTip(this.btn_excluir, "Deletar um registro");
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // tbx_cod_barras
            // 
            this.tbx_cod_barras.BackColor = System.Drawing.Color.White;
            this.tbx_cod_barras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_cod_barras.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cod_barras.ForeColor = System.Drawing.Color.Black;
            this.tbx_cod_barras.Location = new System.Drawing.Point(179, 393);
            this.tbx_cod_barras.MaxLength = 13;
            this.tbx_cod_barras.Name = "tbx_cod_barras";
            this.tbx_cod_barras.Size = new System.Drawing.Size(139, 42);
            this.tbx_cod_barras.TabIndex = 5;
            this.tbx_cod_barras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_cod_barras_KeyUp);
            // 
            // tbx_tombo
            // 
            this.tbx_tombo.BackColor = System.Drawing.Color.White;
            this.tbx_tombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tombo.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tombo.ForeColor = System.Drawing.Color.Black;
            this.tbx_tombo.Location = new System.Drawing.Point(178, 336);
            this.tbx_tombo.MaxLength = 5;
            this.tbx_tombo.Name = "tbx_tombo";
            this.tbx_tombo.Size = new System.Drawing.Size(108, 42);
            this.tbx_tombo.TabIndex = 4;
            // 
            // tbx_autor
            // 
            this.tbx_autor.BackColor = System.Drawing.Color.White;
            this.tbx_autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_autor.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_autor.ForeColor = System.Drawing.Color.Black;
            this.tbx_autor.Location = new System.Drawing.Point(178, 225);
            this.tbx_autor.MaxLength = 150;
            this.tbx_autor.Name = "tbx_autor";
            this.tbx_autor.Size = new System.Drawing.Size(422, 42);
            this.tbx_autor.TabIndex = 2;
            this.tbx_autor.TextChanged += new System.EventHandler(this.tbx_autor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 42);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cód Barras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(71, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 42);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tombo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 42);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gênero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(80, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 42);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 42);
            this.label3.TabIndex = 28;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 42);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 32F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(259, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 59);
            this.panel1.TabIndex = 26;
            // 
            // cbx_genero
            // 
            this.cbx_genero.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cbx_genero.BackColor = System.Drawing.Color.White;
            this.cbx_genero.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.cbx_genero.ForeColor = System.Drawing.Color.Black;
            this.cbx_genero.FormattingEnabled = true;
            this.cbx_genero.ItemHeight = 24;
            this.cbx_genero.Location = new System.Drawing.Point(178, 290);
            this.cbx_genero.Name = "cbx_genero";
            this.cbx_genero.Size = new System.Drawing.Size(424, 32);
            this.cbx_genero.TabIndex = 3;
            // 
            // tbx_codigo
            // 
            this.tbx_codigo.BackColor = System.Drawing.Color.White;
            this.tbx_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_codigo.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.tbx_codigo.ForeColor = System.Drawing.Color.Black;
            this.tbx_codigo.Location = new System.Drawing.Point(178, 110);
            this.tbx_codigo.MaxLength = 10;
            this.tbx_codigo.Name = "tbx_codigo";
            this.tbx_codigo.ReadOnly = true;
            this.tbx_codigo.Size = new System.Drawing.Size(139, 42);
            this.tbx_codigo.TabIndex = 41;
            // 
            // TbxNome
            // 
            this.TbxNome.BackColor = System.Drawing.Color.White;
            this.TbxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxNome.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.TbxNome.ForeColor = System.Drawing.Color.Black;
            this.TbxNome.Location = new System.Drawing.Point(178, 170);
            this.TbxNome.MaxLength = 150;
            this.TbxNome.Name = "TbxNome";
            this.TbxNome.Size = new System.Drawing.Size(422, 42);
            this.TbxNome.TabIndex = 1;
            this.TbxNome.TextChanged += new System.EventHandler(this.TbxNome_TextChanged);
            // 
            // num_caracteres_nome
            // 
            this.num_caracteres_nome.AutoSize = true;
            this.num_caracteres_nome.BackColor = System.Drawing.Color.Transparent;
            this.num_caracteres_nome.Font = new System.Drawing.Font("Agency FB", 16.25F);
            this.num_caracteres_nome.ForeColor = System.Drawing.Color.Black;
            this.num_caracteres_nome.Location = new System.Drawing.Point(603, 182);
            this.num_caracteres_nome.Name = "num_caracteres_nome";
            this.num_caracteres_nome.Size = new System.Drawing.Size(21, 26);
            this.num_caracteres_nome.TabIndex = 42;
            this.num_caracteres_nome.Text = "0";
            this.num_caracteres_nome.Visible = false;
            // 
            // num_caracteres_autor
            // 
            this.num_caracteres_autor.AutoSize = true;
            this.num_caracteres_autor.BackColor = System.Drawing.Color.Transparent;
            this.num_caracteres_autor.Font = new System.Drawing.Font("Agency FB", 16.25F);
            this.num_caracteres_autor.ForeColor = System.Drawing.Color.Black;
            this.num_caracteres_autor.Location = new System.Drawing.Point(603, 237);
            this.num_caracteres_autor.Name = "num_caracteres_autor";
            this.num_caracteres_autor.Size = new System.Drawing.Size(21, 26);
            this.num_caracteres_autor.TabIndex = 43;
            this.num_caracteres_autor.Text = "0";
            this.num_caracteres_autor.Visible = false;
            // 
            // tbx_Localiza
            // 
            this.tbx_Localiza.Font = new System.Drawing.Font("Agency FB", 21.75F);
            this.tbx_Localiza.Location = new System.Drawing.Point(494, 110);
            this.tbx_Localiza.Name = "tbx_Localiza";
            this.tbx_Localiza.Size = new System.Drawing.Size(139, 42);
            this.tbx_Localiza.TabIndex = 6;
            this.tbx_Localiza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(372, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 42);
            this.label6.TabIndex = 46;
            this.label6.Text = "Localizar:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizar.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.Color.Black;
            this.btnLocalizar.Location = new System.Drawing.Point(635, 110);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(51, 42);
            this.btnLocalizar.TabIndex = 47;
            this.btnLocalizar.Text = "IR";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(323, 399);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 35);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Sem Código de Barra";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Agency FB", 18F);
            this.label9.Location = new System.Drawing.Point(23, 672);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 28);
            this.label9.TabIndex = 49;
            this.label9.Text = "Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 677);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(615, 23);
            this.progressBar1.TabIndex = 50;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.Font = new System.Drawing.Font("Agency FB", 18F);
            this.p.Location = new System.Drawing.Point(547, 673);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(0, 28);
            this.p.TabIndex = 51;
            // 
            // CadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::BibliotecaMonteiroLobato.Properties.Resources.fundo7;
            this.ClientSize = new System.Drawing.Size(726, 708);
            this.Controls.Add(this.p);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_Localiza);
            this.Controls.Add(this.num_caracteres_autor);
            this.Controls.Add(this.num_caracteres_nome);
            this.Controls.Add(this.TbxNome);
            this.Controls.Add(this.tbx_codigo);
            this.Controls.Add(this.cbx_genero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbx_cod_barras);
            this.Controls.Add(this.tbx_tombo);
            this.Controls.Add(this.tbx_autor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(178, 283);
            this.MaximizeBox = false;
            this.Name = "CadastroLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.CadastroLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo_registro;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn liv_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn liv_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gen_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn liv_tombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRAVARNOBANCOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivotxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importartxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox tbx_cod_barras;
        private System.Windows.Forms.TextBox tbx_tombo;
        private System.Windows.Forms.TextBox tbx_autor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_genero;
        private System.Windows.Forms.TextBox tbx_codigo;
        private System.Windows.Forms.TextBox TbxNome;
        private System.Windows.Forms.Label num_caracteres_nome;
        private System.Windows.Forms.Label num_caracteres_autor;
        private System.Windows.Forms.ToolTip TooTipCrud;
        private System.Windows.Forms.ToolStripMenuItem vizualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.TextBox tbx_Localiza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label p;
    }
}

