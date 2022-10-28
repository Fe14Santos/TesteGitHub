
namespace BibliotecaMonteiroLobato
{
    partial class VisualzarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualzarLivros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPesquisa = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liv_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liv_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gen_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liv_tombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 46);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 22.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livros Cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tombo:";
            // 
            // tbxPesquisa
            // 
            this.tbxPesquisa.BackColor = System.Drawing.Color.Tomato;
            this.tbxPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPesquisa.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.tbxPesquisa.ForeColor = System.Drawing.Color.Black;
            this.tbxPesquisa.Location = new System.Drawing.Point(73, 77);
            this.tbxPesquisa.Name = "tbxPesquisa";
            this.tbxPesquisa.Size = new System.Drawing.Size(78, 26);
            this.tbxPesquisa.TabIndex = 41;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.Color.Black;
            this.btnLocalizar.Location = new System.Drawing.Point(151, 73);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(42, 29);
            this.btnLocalizar.TabIndex = 42;
            this.btnLocalizar.Text = "Ir";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.AllowUserToResizeColumns = false;
            this.dgvLivros.AllowUserToResizeRows = false;
            this.dgvLivros.BackgroundColor = System.Drawing.Color.Tomato;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.liv_nome,
            this.liv_autor,
            this.gen_nome,
            this.liv_tombo});
            this.dgvLivros.GridColor = System.Drawing.Color.Black;
            this.dgvLivros.Location = new System.Drawing.Point(12, 122);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(673, 535);
            this.dgvLivros.TabIndex = 43;
            // 
            // num
            // 
            this.num.HeaderText = "Nº";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 45;
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
            // VisualzarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaMonteiroLobato.Properties.Resources.fundo7;
            this.ClientSize = new System.Drawing.Size(716, 669);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.tbxPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualzarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualzarLivros";
            this.Load += new System.EventHandler(this.VisualzarLivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPesquisa;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn liv_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn liv_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gen_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn liv_tombo;
    }
}