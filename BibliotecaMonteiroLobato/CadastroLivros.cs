using System;
using System.Windows.Forms;
using System.IO;

namespace BibliotecaMonteiroLobato
{
    public partial class CadastroLivros : Form
    {
        ConexaoBancoDados BancoDados = new ConexaoBancoDados();
        char _modo;
        bool numero_faltando = false;
        public CadastroLivros()
        {
            InitializeComponent();
        }
        private void CadastroLivros_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
            BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
            CarregandoGrid();
        }
        //----------------------------------------------- Inserindo Infromação no GriD ------------------------------------------------------//
        public void CarregandoGrid()
        {
            dataGridView1.Rows.Clear();
            int c = 0;
            while (BancoDados.Liv_Num_Cod[c] != 0)
            {
                dataGridView1.Rows.Add(BancoDados.Liv_Num_Cod[c], BancoDados.Liv_Nome[c], BancoDados.Liv_Autor[c], BancoDados.Liv_Genero[c], BancoDados.Liv_Tombo[c]);
                c++;
            }
        }
        //-----------------------------------------------Atualizando informação dos campos via data grid -----------------------------------//
        public string CodigoDoLivro()
        {
            Random geradorCodigo = new Random();
            bool numeroDuplicado = false;
            string numeroGerado;
            BancoDados.CarregandoCodigo(BancoDados.Liv_Codigo);
            int count = 0;
            while (BancoDados.Liv_Codigo[count] != null)
            {
                count++;
            }
            if (count == 0)
            {
                numeroGerado = geradorCodigo.Next().ToString();
                while (!(numeroGerado.Length == 10))
                {
                    numeroGerado = geradorCodigo.Next().ToString();
                    BancoDados.Liv_Codigo[count] = numeroGerado;
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (numeroDuplicado == false)
                    {
                        numeroGerado = geradorCodigo.Next().ToString();
                        if (numeroGerado.Length == 10)
                        {
                            for (int j = 0; j < count; j++)
                            {
                                if (numeroGerado == BancoDados.Liv_Codigo[j])
                                {
                                    numeroDuplicado = true;
                                    BancoDados.Liv_Codigo[count] = null;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            i--;
                        }
                        BancoDados.Liv_Codigo[count] = numeroGerado;
                    }
                    else
                    {
                        i--;
                        numeroDuplicado = false;
                    }
                }
            }
            return BancoDados.Liv_Codigo[count];
        }
        private void tbn_novo_registro_Click(object sender, EventArgs e)
        {
            btn_atualizar.Enabled = false; ;
            btn_excluir.Enabled = false; ;
            num_caracteres_nome.Visible = true;
            num_caracteres_autor.Visible = true;

            LimparCampos();
            HabilitaCampos();
            tbx_codigo.Text = CodigoDoLivro();
            BancoDados.CarregandoBancoDadosGenero(BancoDados.Gen_Genero);
            int c = 0;
            while (BancoDados.Gen_Genero[c] != null)
            {
                cbx_genero.Items.Add(String.Format("{0}", BancoDados.Gen_Genero[c]));
                c++;
            }
            _modo = 'N';
        }
        public void HabilitaCampos()
        {
            tbx_codigo.Enabled = true;
            TbxNome.Enabled = true;
            tbx_autor.Enabled = true;
            cbx_genero.Enabled = true;
            tbx_tombo.Enabled = true;
            tbx_cod_barras.Enabled = true;
            TbxNome.Focus();
        }
        public void DesabilitaCampos()
        {
            TbxNome.Enabled = false;
            tbx_autor.Enabled = false;
            cbx_genero.Enabled = false;
            tbx_tombo.Enabled = false;
            tbx_cod_barras.Enabled = false;
        }
        public void LimparCampos()
        {
            TbxNome.Text = "";
            tbx_autor.Text = "";
            cbx_genero.Text = "";
            tbx_tombo.Text = "";
            tbx_cod_barras.Text = "";
        }
        private void AtualizaCampos()
        {
            int linhadgv = dataGridView1.CurrentRow.Index;

            tbx_codigo.Text = BancoDados.Liv_Codigo[linhadgv].ToString();
            TbxNome.Text = BancoDados.Liv_Nome[linhadgv];
            tbx_autor.Text = BancoDados.Liv_Autor[linhadgv];
            tbx_tombo.Text = BancoDados.Liv_Tombo[linhadgv];
            tbx_cod_barras.Text = BancoDados.Liv_Cod_Barras[linhadgv];
            cbx_genero.Text = cbx_genero.GetItemText(BancoDados.Liv_Genero[linhadgv]);
        }
        private void AtualizaCampos(int i)
        {
            int linhadgv = i - 1;

            tbx_codigo.Text = BancoDados.Liv_Codigo[linhadgv].ToString();
            TbxNome.Text = BancoDados.Liv_Nome[linhadgv];
            tbx_autor.Text = BancoDados.Liv_Autor[linhadgv];
            tbx_tombo.Text = BancoDados.Liv_Tombo[linhadgv];
            tbx_cod_barras.Text = BancoDados.Liv_Cod_Barras[linhadgv];
            cbx_genero.Text = cbx_genero.GetItemText(BancoDados.Liv_Genero[linhadgv]);
            //dataGridView1[0, linhadgv].Selected = true;
            tbx_Localiza.Text = "";
        }
        private int indNumCod_VerificadorCodigoVazio()
        {
            int i = 0;
            int indice = 0;
            while (BancoDados.Liv_Num_Cod[i] != 0)
            {

                if (BancoDados.Liv_Num_Cod[i] == i + 1)
                {
                    i++;
                }
                else
                {
                    numero_faltando = true;
                    indice = i + 1;
                    i++;
                    break;
                }
            }
            return indice;
        }
        public void CarrregandoGenero()
        {
            BancoDados.CarregandoBancoDadosGenero(BancoDados.Gen_Genero);
            int c = 0;
            while (BancoDados.Gen_Genero[c] != null)
            {
                cbx_genero.Items.Add(BancoDados.Gen_Genero[c]);
                c++;
            }
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            btn_novo_registro.Enabled = false;
            btn_excluir.Enabled = false;
            num_caracteres_nome.Visible = true;
            num_caracteres_autor.Visible = true;
            BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
            CarrregandoGenero();
            HabilitaCampos();
            AtualizaCampos();
            cbx_genero.Focus();
            _modo = 'A';
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            AtualizaCampos();
        }
        private void gRAVARNOBANCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
            CarrregandoGenero();
            _modo = 'D';
            int index = dataGridView1.CurrentRow.Index + 1;

            if ((index == dataGridView1.Rows.Count) && dataGridView1.Rows.Count != 1)
            {
                if (MessageBox.Show("Deseja excluir permanente este registro", "Menssage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDados.Deletar(tbx_codigo.Text);
                    this.Close();
                }
            }
            else if (MessageBox.Show("Deseja excluir permanente este registro", "Menssage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BancoDados.Deletar(tbx_codigo.Text);
                if (MessageBox.Show("Registro excluído com sucesso, para atualizar a mudanças clique em [OK]", "Mensagem de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                    this.Close();
                }
            }
        }
        private void importartxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label9.Text = "Importando...";
            Livros livrosImport = new Livros();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string caminho = ofd.FileName;
            if (caminho != "")
            {
                FileStream fsTxt = new FileStream(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lendoTxt = new StreamReader(fsTxt);

                string linha;
                int c = 0;
                int i = 0;
                while (!(lendoTxt.EndOfStream))
                {
                    linha = lendoTxt.ReadLine();
                    c++;
                }             
                progressBar1.Maximum = c;
                lendoTxt.Close();
                FileStream Txt = new FileStream(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lendoT = new StreamReader(Txt);
                while (!(lendoT.EndOfStream))
                {
                    linha = lendoT.ReadLine();
                    string[] al = linha.Split(';');
                    livrosImport.Liv_Num_Cod[i] = int.Parse(al[0]);
                    livrosImport.Liv_Codigo[i] = al[1];
                    livrosImport.Liv_Nome[i] = al[2];
                    livrosImport.intGenero[i] = int.Parse(al[3]);
                    livrosImport.Liv_Autor[i] = al[4];
                    livrosImport.Liv_Tombo[i] = al[5];
                    livrosImport.Liv_Cod_Barras[i] = al[6];
                    BancoDados.NovoRegistro(livrosImport.Liv_Num_Cod[i], livrosImport.Liv_Codigo[i], livrosImport.Liv_Nome[i], livrosImport.intGenero[i], livrosImport.Liv_Autor[i], livrosImport.Liv_Tombo[i], livrosImport.Liv_Cod_Barras[i]);
                    
                    i++;
                    progressBar1.Value = i;
                    //label9.Text = ((i / c) * 100).ToString();
                    //label9.Refresh();
                   

                }
                lendoTxt.Close();
                MessageBox.Show("Arquivo importando no Banco de Dados", "Mensagem de confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                CarregandoGrid();
            }
        }
        private void arquivotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BancoDados.ExportarBanco(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.intGenero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
            SaveFileDialog caminho = new SaveFileDialog();
            caminho.Filter = "Arquivos de texto (*.txt)|*.txt|Arquivos de texto (*.csv)|*.csv|Todos os arquivos (*.*)|*.*";
            caminho.ShowDialog();
            try
            {
                string local_salvar = caminho.FileName;
                if (caminho.FileName != "")
                {
                    FileStream fs = new FileStream(local_salvar, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    int i = 0;

                    string linha = "";
                    while (BancoDados.Liv_Codigo[i] != null)
                    {
                        linha += String.Format("{0};{1};{2};{3};{4};{5};{6}\n", BancoDados.Liv_Num_Cod[i], BancoDados.Liv_Codigo[i], BancoDados.Liv_Nome[i], BancoDados.intGenero[i], BancoDados.Liv_Autor[i], BancoDados.Liv_Tombo[i], BancoDados.Liv_Cod_Barras[i]);
                        i++;
                    }
                    StreamWriter sr = new StreamWriter(fs);
                    sr.Write(linha);
                    sr.Close();
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (_modo == 'A')
            {
                BancoDados.Alterar(TbxNome.Text, tbx_autor.Text, cbx_genero.SelectedIndex + 1, tbx_tombo.Text, tbx_cod_barras.Text, tbx_codigo.Text);
                DesabilitaCampos();
                CarregandoGrid();
                if (BancoDados.MensagemErro != null)
                {
                    MessageBox.Show("Erro ao alterar registro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(BancoDados.MensagemErro);
                }
                else
                    MessageBox.Show("Reinicia o programa para vizualizar as alterações", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (_modo == 'N')
            {
                ConexaoBancoDados n = new ConexaoBancoDados();
                int num_faltando = indNumCod_VerificadorCodigoVazio();
                bool verificadorRedundancia = false;
                for (int index = 0; BancoDados.Liv_Tombo[index] != null; index++)
                {
                    if (BancoDados.Liv_Tombo[index] == tbx_tombo.Text)
                    {
                        verificadorRedundancia = true;
                    }
                }
                if (verificadorRedundancia == true)
                {
                    MessageBox.Show("Livro já se encontra cadastrado", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numero_faltando = false;
                }
                else
                {
                    if (numero_faltando == true)
                    {
                        n.NovoRegistro(num_faltando, CodigoDoLivro(), TbxNome.Text, cbx_genero.SelectedIndex + 1, tbx_autor.Text, tbx_tombo.Text, tbx_cod_barras.Text);
                        if (n._erro_cadastrar == false)
                        {
                            n.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                            numero_faltando = false;
                            CarregandoGrid();
                            DesabilitaCampos();
                            MessageBox.Show("Livro cadastrado com Sucesso!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Livro NÃO cadastrado!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(n.MensagemErro);
                        }
                    }
                    else
                    {
                        int count = BancoDados.indexLinha("liv_num_cod","livros");
                        n.NovoRegistro(count, CodigoDoLivro(), TbxNome.Text, cbx_genero.SelectedIndex + 1, tbx_autor.Text, tbx_tombo.Text, tbx_cod_barras.Text); ;
                        if (n._erro_cadastrar == false)
                        {
                            n.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                            CarregandoGrid();
                            DesabilitaCampos();
                            MessageBox.Show("Livro cadastrado com Sucesso!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Livro NÃO cadastrado!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(n.MensagemErro);
                        }
                    }
                }
            }
            HabilitaBotoes();
            num_caracteres_nome.Visible = false;
            num_caracteres_autor.Visible = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            num_caracteres_nome.Visible = false;
            num_caracteres_autor.Visible = false;
            HabilitaBotoes();
            LimparCampos();
            DesabilitaCampos();
            CarregandoGrid();
            AtualizaCampos();
            btnLocalizar.Focus();
        }
        private void TbxNome_TextChanged(object sender, EventArgs e)
        {
            num_caracteres_nome.Text = (120 - TbxNome.Text.Length).ToString();
            num_caracteres_nome.Refresh();
        }
        private void tbx_autor_TextChanged(object sender, EventArgs e)
        {
            num_caracteres_autor.Text = (120 - tbx_autor.Text.Length).ToString();
            num_caracteres_autor.Refresh();
        }
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualzarLivros vl = new VisualzarLivros();
            vl.ShowDialog();
        }
        private void nOVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void tbx_cod_barras_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_modo == 'A')
                {
                    BancoDados.Alterar(TbxNome.Text, tbx_autor.Text, cbx_genero.SelectedIndex + 1, tbx_tombo.Text, tbx_cod_barras.Text, tbx_codigo.Text);
                    DesabilitaCampos();
                    CarregandoGrid();
                    if (BancoDados.MensagemErro != null)
                    {
                        MessageBox.Show("Erro ao alterar registro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(BancoDados.MensagemErro);
                    }
                    else
                        MessageBox.Show("Reinicia o programa para vizualizar as alterações", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (_modo == 'N')
                {
                    ConexaoBancoDados n = new ConexaoBancoDados();
                    int num_faltando = indNumCod_VerificadorCodigoVazio();
                    bool verificadorRedundancia = false;
                    for (int index = 0; BancoDados.Liv_Tombo[index] != null; index++)
                    {
                        if (BancoDados.Liv_Tombo[index] == tbx_tombo.Text)
                        {
                            verificadorRedundancia = true;
                        }
                    }
                    if (verificadorRedundancia == true)
                    {
                        MessageBox.Show("Livro já se encontra cadastrado", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numero_faltando = false;
                    }
                    else
                    {
                        if (numero_faltando == true)
                        {
                            n.NovoRegistro(num_faltando, CodigoDoLivro(), TbxNome.Text, cbx_genero.SelectedIndex + 1, tbx_autor.Text, tbx_tombo.Text, tbx_cod_barras.Text);
                            if (n._erro_cadastrar == false)
                            {
                                n.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                                numero_faltando = false;
                                CarregandoGrid();
                                DesabilitaCampos();
                                MessageBox.Show("Livro cadastrado com Sucesso!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Livro NÃO cadastrado!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MessageBox.Show(n.MensagemErro);
                            }
                        }
                        else
                        {
                            int count = BancoDados.indexLinha("liv_num_cod","livros");
                            n.NovoRegistro(count, CodigoDoLivro(), TbxNome.Text, cbx_genero.SelectedIndex + 1, tbx_autor.Text, tbx_tombo.Text, tbx_cod_barras.Text); ;
                            if (n._erro_cadastrar == false)
                            {
                                n.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                                CarregandoGrid();
                                DesabilitaCampos();
                                MessageBox.Show("Livro cadastrado com Sucesso!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Livro NÃO cadastrado!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MessageBox.Show(n.MensagemErro);
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConexaoBancoDados BancoDados = new ConexaoBancoDados();
                BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                int indice = BancoDados.Bascar(tbx_Localiza.Text, tbx_Localiza.Text);
                if (indice < 1)
                {
                    MessageBox.Show("Livro não cadastrado");
                }
                else
                {
                    AtualizaCampos(indice);
                    MessageBox.Show(String.Format("[{0} - {1} - {2} - {3} - {4}]", BancoDados.Liv_Num_Cod[indice], BancoDados.Liv_Nome[indice], BancoDados.Liv_Autor[indice], BancoDados.Liv_Genero[indice], BancoDados.Liv_Tombo[indice]), "Mensagem", MessageBoxButtons.OK);
                    
                }
            }
        }
        public void HabilitaBotoes()
        {
            btn_novo_registro.Enabled = true;
            btn_atualizar.Enabled = true;
            btn_excluir.Enabled = true;           
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ConexaoBancoDados BancoDados = new ConexaoBancoDados();
            BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
            int indice = BancoDados.Bascar(tbx_Localiza.Text, tbx_Localiza.Text)-1;
            if (indice < 1)
            {
                MessageBox.Show("Livro não cadastrado","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {                               
                dataGridView1[0, indice].Selected = true;
                MessageBox.Show(String.Format("[{0} - {1} - {2} - {3} - {4}]", BancoDados.Liv_Num_Cod[indice], BancoDados.Liv_Nome[indice], BancoDados.Liv_Autor[indice], BancoDados.Liv_Genero[indice], BancoDados.Liv_Tombo[indice]), "Mensagem",MessageBoxButtons.OK);
                AtualizaCampos(indice);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_modo == 'A')
            {
                BancoDados.Alterar(TbxNome.Text, tbx_autor.Text, cbx_genero.SelectedIndex + 1, tbx_tombo.Text, tbx_cod_barras.Text, tbx_codigo.Text);
                DesabilitaCampos();
                CarregandoGrid();
                if (BancoDados.MensagemErro != null)
                {
                    MessageBox.Show("Erro ao alterar registro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(BancoDados.MensagemErro);
                }
                else
                    MessageBox.Show("Reinicia o programa para vizualizar as alterações", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (_modo == 'N')
            {
                ConexaoBancoDados n = new ConexaoBancoDados();
                int num_faltando = indNumCod_VerificadorCodigoVazio();
                bool verificadorRedundancia = false;
                for (int index = 0; BancoDados.Liv_Tombo[index] != null; index++)
                {
                    if (BancoDados.Liv_Tombo[index] == tbx_tombo.Text)
                    {
                        verificadorRedundancia = true;
                    }
                }
                if (verificadorRedundancia == true)
                {
                    MessageBox.Show("Livro já se encontra cadastrado", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numero_faltando = false;
                }
                else
                {
                    if (numero_faltando == true)
                    {
                        n.NovoRegistro(num_faltando, CodigoDoLivro(), TbxNome.Text, cbx_genero.SelectedIndex + 1, tbx_autor.Text, tbx_tombo.Text,"");
                        if (n._erro_cadastrar == false)
                        {
                            n.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                            numero_faltando = false;
                            CarregandoGrid();
                            DesabilitaCampos();
                            MessageBox.Show("Livro cadastrado com Sucesso!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Livro NÃO cadastrado!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(n.MensagemErro);
                        }
                    }
                    else
                    {
                        int count = BancoDados.indexLinha("liv_num_cod", "livros");
                        n.NovoRegistro(count, CodigoDoLivro(), TbxNome.Text, cbx_genero.SelectedIndex + 1, tbx_autor.Text, tbx_tombo.Text, ""); ;
                        if (n._erro_cadastrar == false)
                        {
                            n.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
                            CarregandoGrid();
                            DesabilitaCampos();
                            MessageBox.Show("Livro cadastrado com Sucesso!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Livro NÃO cadastrado!!!", "Mensagem de Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(n.MensagemErro);
                        }
                    }
                }
            }
            checkBox1.Checked = false;
        }
    }
}
