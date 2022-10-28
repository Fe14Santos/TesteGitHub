using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMonteiroLobato
{
    public partial class Login : Form
    {
        bool logado = false;
        public Login()
        {
            InitializeComponent();
        }
        public Login(bool usuario_logado)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoBancoDados cbd = new ConexaoBancoDados();
            cbd.Login();
            int indice=0;

            for (int i = 0; i < cbd.Codigo.Length; i++)
            {
                if ((tbx_usuario.Text == cbd.CPF[i]) && (tbx_senha.Text == cbd.Senha[i]))
                {
                    logado = true;
                    indice = i;
                }
            }
            if (logado == true)
            {
                Principal p = new Principal(cbd.Nome[indice], logado);
                this.Hide();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //if ((tbx_usuario.Text == cbd.CPF[i]) || (tbx_senha.Text == cbd.Senha[i]))
                //{
                //    MessageBox.Show("Usuário ou Senha Inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("Usuário não cadastrado ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                //    return;
                //}

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tbx_senha.UseSystemPasswordChar = false;
            else
                tbx_senha.UseSystemPasswordChar = true;


        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }
        public void LimparCampos()
        {
            tbx_senha.Text = "";
            tbx_usuario.Text = "";
        }
    }
}
