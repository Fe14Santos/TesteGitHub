using System;
using System.Windows.Forms;

namespace BibliotecaMonteiroLobato
{
    public partial class Emprestimo : Form
    {
        string usuario = "";
        ConexaoBancoDados cbd = new ConexaoBancoDados();
        Livros livros;
        public Emprestimo()
        {
            InitializeComponent();
        }
        public Emprestimo(string nomeUsuario)
        {
            this.usuario = nomeUsuario;
            InitializeComponent();

        }
        private void Emprestimo_Load(object sender, EventArgs e)
        {
            label6.Text = usuario;
            cbd.CarregandoBancoArray(cbd.Liv_Num_Cod, cbd.Liv_Codigo, cbd.Liv_Nome, cbd.Liv_Autor, cbd.Liv_Genero, cbd.Liv_Tombo, cbd.Liv_Cod_Barras);
            HabilitaCampos();
            tbx_Localizar.Focus();
        }
        public void CarregandoSerie()
        {

        }
        /*Habiliatar Campos*/
        public void HabilitaCampos()
        {
            if (rb_aluno_sim.Checked)
            {
                tbxNome.Enabled = true;
                cbxSerie.Enabled = true;
                tbxEndereco.Enabled = false;
                mtbContato.Enabled = false;
                lbEndereco.Enabled = false;
                lbContato.Enabled = false;
            }
            else
            {
                tbxNome.Enabled = true;
                cbxSerie.Enabled = false;
                tbxEndereco.Enabled = true;
                mtbContato.Enabled = true;
                lbEndereco.Enabled = true;
                lbContato.Enabled = true;
            }
        }
        private void rb_aluno_sim_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaCampos();
        }
        private void rb_aluno_nao_CheckedChanged_1(object sender, EventArgs e)
        {
            HabilitaCampos();
        }
        private void tbx_Localizar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                livros = cbd.BascarEmprestimo(tbx_Localizar.Text, tbx_Localizar.Text);
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
                            cbxTitulo.Items.Add(obj);
                        }
                    }
                    cbxTitulo.Text = cbxTitulo.GetItemText(livros.Liv_Nome[0]);
                    AtualizaLista(0);
                    tbx_Localizar.Text = "";
                }
            }
        }
        private void cbxTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaLista(cbxTitulo.SelectedIndex);
        }
        public void AtualizaLista(int i)
        {
            //MessageBox.Show(i.ToString());
            tbxCodigo.Text = livros.Liv_Codigo[i];
            tbxAutor.Text = livros.Liv_Autor[i];
            tbxGenero.Text = livros.Liv_Genero[i];
            tbxTombo.Text = livros.Liv_Tombo[i];
        }
        private void tbxTombo_KeyUp(object sender, KeyEventArgs e)
        {
            cbxTitulo.Items.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                livros = cbd.BascarEmprestimo(tbxTombo.Text, tbxTombo.Text);
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
                            cbxTitulo.Items.Add(obj);
                        }
                    }
                    cbxTitulo.Text = cbxTitulo.GetItemText(livros.Liv_Nome[0]);
                    AtualizaLista(0);
                   /* tbxTombo.Text = ""*/;
                }
            }
        }
        private void cbxPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {        
            dtpDevolucao.Value = dtpEntrega.Value.AddDays(double.Parse(cbxPeriodo.Text));     
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            bool status_emprestimo = false;
            
            ConexaoBancoDados cbd = new ConexaoBancoDados();
            int i = cbd.indexLinha("emp_codigo", "emprestimo");
            status_emprestimo = cbd.Emprestimo(i, tbxNome.Text, cbxSerie.SelectedIndex + 1, mtbContato.Text, cbxTitulo.Text, tbxAutor.Text, tbxTombo.Text, tbxGenero.Text, tbxCodigo.Text, dtpEntrega.Text, cbxPeriodo.SelectedIndex + 1, '1',tbxEndereco.Text);
            if (status_emprestimo == false)
            {
                MessageBox.Show("Emprestimo Realizado com Sucesso!!!","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Emprestimo não Realizado","Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
