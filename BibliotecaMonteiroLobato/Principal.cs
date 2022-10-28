using System;
using System.Windows.Forms;

namespace BibliotecaMonteiroLobato
{
   
    public partial class Principal : Form
    {
        ConexaoBancoDados cbd = new ConexaoBancoDados();
        Livros livros;
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(string usuario_logado,bool logado)
        {
            InitializeComponent();
            usuario.Text += usuario_logado;
            if (logado == true)
            {
                lk_sair.Enabled = true;
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLivros cl = new CadastroLivros();
            cl.ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
           
            ConexaoBancoDados BancoDados = new ConexaoBancoDados();
            BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);

            if (rbtCodigo.Checked == true)
            {
                string[] resultado = BancoDados.BascarLivros(tbxPesquisa.Text,"codigo");
                int p = 0;
                while (resultado[p] != null)
                {
                    lbxResultadoPesquisa.Items.Add(resultado[p]);
                    p++;
                }
                if (p == 0)
                {
                    MessageBox.Show("Nenhum resultado encontrato", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxPesquisa.Text = "";
                }
                else                
                {
                    tbxPesquisa.Text = "";
                    MessageBox.Show(p + " resultado(s) encontrato(s)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            if (rbtNome.Checked == true)
            {
                string[] resultado = BancoDados.BascarLivros(tbxPesquisa.Text, "nome");
                int p = 0;
                while (resultado[p] != null)
                {
                    lbxResultadoPesquisa.Items.Add(resultado[p]);
                    p++;
                }
                if (p == 0)
                {
                    MessageBox.Show("Nenhum resultado encontrato", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show(p + " resultado(s) encontrato(s)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxPesquisa.Text = "";
                }
                
            }
            if (rbtAutor.Checked == true)
            {
                string[] resultado = BancoDados.BascarLivros(tbxPesquisa.Text, "autor");
                int p = 0;
                while (resultado[p] != null)
                {
                    lbxResultadoPesquisa.Items.Add(resultado[p]);
                    p++;
                }
                if (p == 0)
                {
                    MessageBox.Show("Nenhum resultado encontrato", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show(p + " resultado(s) encontrato(s)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxPesquisa.Text = "";
                }
               
            }
            if (rbtTombo.Checked == true)
            {
                string[] resultado = BancoDados.BascarLivros(tbxPesquisa.Text, "tombo");
                int p = 0;
                while (resultado[p] != null)
                {
                    lbxResultadoPesquisa.Items.Add(resultado[p]);
                    p++;
                }
                if (p == 0)
                {
                    tbxPesquisa.Text = "";
                    MessageBox.Show("Nenhum resultado encontrato", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbxPesquisa.Text = "";
                    MessageBox.Show(p + " resultado(s) encontrato(s)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroLivros cl = new CadastroLivros();
            cl.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lk_sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool logado = false;
            Login login = new Login(logado);
            this.Hide();
            login.ShowDialog();
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo ep = new Emprestimo(usuario.Text);
            ep.ShowDialog();
        }

        private void tbxPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                livros = cbd.BascarEmprestimo(tbxPesquisa.Text, tbxPesquisa.Text);
                if (livros.Liv_Codigo.Length < 1)
                {
                    MessageBox.Show("Livro não cadastrado ou Não contém Código Barra Cadastrado");
                }
                else
                {
                    foreach (var obj in livros.Liv_Nome)
                    {
                        if (obj != null)
                        {
                            lbxResultadoPesquisa.Items.Add(obj);
                        }
                    }
                }
            }
        }
    }
}
