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
    public partial class VisualzarLivros : Form
    {
        ConexaoBancoDados BancoDados = new ConexaoBancoDados();
        public VisualzarLivros()
        {
            InitializeComponent();
        }
        private void VisualzarLivros_Load(object sender, EventArgs e)
        {
            BancoDados.CarregandoBancoArray(BancoDados.Liv_Num_Cod, BancoDados.Liv_Codigo, BancoDados.Liv_Nome, BancoDados.Liv_Autor, BancoDados.Liv_Genero, BancoDados.Liv_Tombo, BancoDados.Liv_Cod_Barras);
            CarregandoGrid();
        }
        public void CarregandoGrid()
        {
            dgvLivros.Rows.Clear();
            int c = 0;
            dgvLivros.Rows.Clear();
          
            while (BancoDados.Liv_Codigo[c] != null)
            {
                dgvLivros.Rows.Add(BancoDados.Liv_Num_Cod[c], BancoDados.Liv_Nome[c], BancoDados.Liv_Autor[c], BancoDados.Liv_Genero[c], BancoDados.Liv_Tombo[c]);
                c++;
            }
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            bool encontrou = false;
            //dgvLivros[0, 0].Selected = false;
            for (int i = 0; i < BancoDados.Liv_Tombo.Length; i++)
            {
                if (BancoDados.Liv_Tombo[i] == tbxPesquisa.Text)
                {                   
                    dgvLivros[0, i].Selected = true;
                    encontrou = true;                 
                }
            }
            if (encontrou == false)
            {
                MessageBox.Show("Nenhum registro encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
    }
}
