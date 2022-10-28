using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BibliotecaMonteiroLobato
{
    class ConexaoBancoDados : Livros
    {
        string _mensagemErro;
        public bool _erro_cadastrar = false;

        public string MensagemErro
        {
            get { return _mensagemErro; }
            set { _mensagemErro = value; }
        }
        MySqlConnection Conexao;
        public MySqlCommand InstrucaoSQL(string instrucao, MySqlConnection Conexao)
        {
            MySqlCommand sql = new MySqlCommand(instrucao, Conexao);
            return sql;
        }
        public void Login()
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                MySqlDataReader lendo = InstrucaoSQL("select * from usuario", Conexao).ExecuteReader();
                int i = 0;
                while (lendo.Read())
                {
                    Nome[i] = lendo.GetString(1);
                    CPF[i] = lendo.GetString(2);
                    Senha[i] = lendo.GetString(3);
                    i++;
                }
                Conexao.Close();
                lendo.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.Message.ToString();
            }
        }
        //------------------------------------------ Comandos CRUD -------------------------------------------------------------------//

        public bool NovoRegistro(int num_cod, string codigo, string nome, int cod_genero, string autor, string tombo, string cod_barra)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            //MySqlCommand instrucaoSql = new MySqlCommand("insert into livros (liv_num_cod,liv_codigo,liv_nome,liv_cod_genero,liv_autor,liv_tombo,liv_codigo_barra) value (" + num_cod + ",'" + codigo + "','" + nome + "'," + cod_genero + ",'" + autor + "','" + tombo + "','" + cod_barra + "')", Conexao);
            try
            {
                Conexao.Open();
                InstrucaoSQL("insert into livros (liv_num_cod,liv_codigo,liv_nome,liv_cod_genero,liv_autor,liv_tombo,liv_codigo_barra) value (" + num_cod + ",'" + codigo + "','" + nome + "'," + cod_genero + ",'" + autor + "','" + tombo + "','" + cod_barra + "')", Conexao).ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                _erro_cadastrar = true;
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
            return _erro_cadastrar;
        }
        public bool Emprestimo(int emp_codigo, string emp_nome, int emp_cod_serie, string emp_contato, string emp_titulo, string emp_autor, string emp_tombo, string emp_genero, string emp_liv_codigo, string emp_data_emprestimo, int emp_periodo,char status,string emp_endereco)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                InstrucaoSQL("INSERT INTO emprestimo (emp_codigo, emp_nome, emp_cod_serie, emp_contato, emp_titulo, emp_autor, emp_tombo, emp_genero, emp_liv_codigo, emp_data_emprestimo,emp_periodo,emp_endereco) VALUES ('"+ emp_codigo + "', '"+ emp_nome + "', "+emp_cod_serie+", '"+emp_contato+"', '"+emp_titulo+"', '"+emp_autor+"', '"+emp_tombo+"', '"+emp_genero+"', '"+emp_liv_codigo+"', '"+emp_data_emprestimo+"', "+emp_periodo+",'"+emp_endereco+"');", Conexao).ExecuteNonQuery();
                InstrucaoSQL("UPDATE livros SET liv_disponivel = "+status+" WHERE (liv_codigo= '"+ emp_liv_codigo + "');", Conexao).ExecuteNonQuery();

            }
            catch (MySqlException erro)
            {
                _erro_cadastrar = true;
                MensagemErro = erro.ToString();
            }
            return _erro_cadastrar;
        }
        public void Alterar(string nome, string autor, int cod_genero, string tombo, string cod_barra, string codigo)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                InstrucaoSQL("update livros set liv_nome = '" + nome + "',liv_autor='" + autor + "',liv_tombo ='" + tombo + "',liv_cod_genero=" + cod_genero + ",liv_codigo_barra= '" + cod_barra + "' where liv_codigo =" + codigo + ";", Conexao).ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        public void Deletar(string codigo)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                InstrucaoSQL("delete from livros where liv_codigo='" + codigo + "';", Conexao).ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        //-------------------------- Carregando Array com as informações do Banco de Dados-------------------------------\\
        public void CarregandoBancoArray(int[] livNumCod, string[] livCodigo, string[] livNome, string[] livAutor, string[] livGenero, string[] livTombo, string[] livCodBarra)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            MySqlCommand comandoSql = new MySqlCommand("select liv_num_cod as 'Nº', liv_codigo as 'Código',liv_nome as 'Nome',liv_autor as 'Autor', gen_nome as 'Gênero',liv_tombo as 'Tombo' ,liv_codigo_barra as 'Cód Barras' from livros join genero on liv_cod_genero = gen_codigo order by(liv_num_cod)", Conexao);
            try
            {
                Conexao.Open();
                MySqlDataReader Lendo = InstrucaoSQL("select liv_num_cod as 'Nº', liv_codigo as 'Código',liv_nome as 'Nome',liv_autor as 'Autor', gen_nome as 'Gênero',liv_tombo as 'Tombo' ,liv_codigo_barra as 'Cód Barras' from livros join genero on liv_cod_genero = gen_codigo order by(liv_num_cod)", Conexao).ExecuteReader();
                int count = 0;

                while (Lendo.Read())
                {
                    livNumCod[count] = Lendo.GetInt16(0);
                    livCodigo[count] = Lendo.GetString(1);
                    livNome[count] = Lendo.GetString(2);
                    livAutor[count] = Lendo.GetString(3);
                    livGenero[count] = Lendo.GetString(4);
                    livTombo[count] = Lendo.GetString(5);
                    livCodBarra[count] = Lendo.GetString(6);
                    count++;
                }
                Lendo.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        //===============================================================================================
        public Livros Array()
        {
            Livros livro = new Livros();
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            MySqlCommand comandoSql = new MySqlCommand("select liv_num_cod as 'Nº', liv_codigo as 'Código',liv_nome as 'Nome',liv_autor as 'Autor', gen_nome as 'Gênero',liv_tombo as 'Tombo' ,liv_codigo_barra as 'Cód Barras' from livros join genero on liv_cod_genero = gen_codigo order by(liv_num_cod)", Conexao);
            try
            {
                Conexao.Open();
                MySqlDataReader Lendo = InstrucaoSQL("select liv_num_cod as 'Nº', liv_codigo as 'Código',liv_nome as 'Nome',liv_autor as 'Autor', gen_nome as 'Gênero',liv_tombo as 'Tombo' ,liv_codigo_barra as 'Cód Barras' from livros join genero on liv_cod_genero = gen_codigo order by(liv_num_cod)", Conexao).ExecuteReader();
                int count = 0;
                while (Lendo.Read())
                {
                    livro.Liv_Num_Cod[count] = Lendo.GetInt16(0);
                    livro.Liv_Codigo[count] = Lendo.GetString(1);
                    livro.Liv_Nome[count] = Lendo.GetString(2);
                    livro.Liv_Autor[count] = Lendo.GetString(3);
                    livro.Liv_Genero[count] = Lendo.GetString(4);
                    livro.Liv_Tombo[count] = Lendo.GetString(5);
                    livro.Liv_Cod_Barras[count] = Lendo.GetString(6);
                    count++;
                }
                Lendo.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
            return livro;
        }
        //===============================================================================================
        public void CarregandoBancoDadosGenero(string[] genNome)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                MySqlDataReader LendoGenero = InstrucaoSQL("select gen_nome as Nome from genero;", Conexao).ExecuteReader();
                int count = 0;
                while (LendoGenero.Read())
                {
                    genNome[count] = LendoGenero.GetString(0);
                    count++;
                }
                LendoGenero.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        public void CarregandoCodigo(string[] LivCodigo)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                MySqlDataReader LendoCodigo = InstrucaoSQL("select liv_codigo as Codigo from livros;", Conexao).ExecuteReader();
                int count = 0;
                while (LendoCodigo.Read())
                {
                    LivCodigo[count] = LendoCodigo.GetString(0);
                }
                LendoCodigo.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        public void CarregandoSerie(string[] Serie)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                MySqlDataReader LendoSerie = InstrucaoSQL("select ser_nome as Nome from serie;", Conexao).ExecuteReader();
                int count = 0;
                while (LendoSerie.Read())
                {
                    Serie[count] = LendoSerie.GetString(0);
                }
                LendoSerie.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }

        //----------------------------- Pesquisando livros ------------------------------------------------------\\
        public string[] BascarLivros(string name, string modo)
        {
            string[] resultaPesquisa = new string[100];
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            MySqlCommand comando = new MySqlCommand("select * from livros where liv_" + modo + " like '%" + name + "%';", Conexao);
            if (modo == "codigo")  {
                comando = new MySqlCommand("select * from livros where liv_" + modo + " = '" + name + "' ;", Conexao);
            }
            try
            {
                Conexao.Open();
                MySqlDataReader Buscando = comando.ExecuteReader();
                int i = 0;
                while (Buscando.Read())
                {
                    resultaPesquisa[i] = Buscando.GetInt32(0) + " - " + Buscando.GetString(1) + " - " + Buscando.GetString(2) + " - " + Buscando.GetString(4) + " - " + Buscando.GetString(5) + " - " + Buscando.GetString(6);
                    i++;
                }
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            return resultaPesquisa;
        }
        public int Bascar(string tombo, string codigo_barra)
        {
            //----------------------------- Pesquisando livros por Codigo Barra ------------------------------------------------------\\
            int index = 0;
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            MySqlCommand comando = new MySqlCommand("select * from livros where liv_tombo='" + tombo + "' or liv_codigo_barra='" + codigo_barra + "';", Conexao);
            try
            {
                Conexao.Open();
                MySqlDataReader Buscando = comando.ExecuteReader();
                while (Buscando.Read())
                {
                    index = Buscando.GetInt32(0);
                    break;
                }
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            return index;
        }
        public Livros BascarEmprestimo(string tombo, string codigo_barra)
        {
            //----------------------------- Pesquisando livros por Codigo Barra ------------------------------------------------------\\
            int index = 0;
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            MySqlCommand comando = new MySqlCommand("select liv_codigo, liv_nome, gen_nome,liv_autor, liv_tombo from livros  join genero on liv_cod_genero= gen_codigo where liv_tombo='" + tombo + "' or liv_codigo_barra='" + codigo_barra + "';", Conexao);
            Livros l = new Livros();
            try
            {
                Conexao.Open();
                MySqlDataReader Buscando = comando.ExecuteReader();
                while (Buscando.Read())
                {
                    l.Liv_Codigo[index] = Buscando.GetString(0);
                    l.Liv_Nome[index] = Buscando.GetString(1);
                    l.Liv_Genero[index] = Buscando.GetString(2);
                    l.Liv_Autor[index] = Buscando.GetString(3);
                    l.Liv_Tombo[index] = Buscando.GetString(4);
                    index++;
                }
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            return l;
        }
        //------------------------------------Exportando banco para TXT - //Importação de Arquivos TXT--------------------------------------
        public void ExportarBanco(int[] livNumCod, string[] livCodigo, string[] livNome, string[] livAutor, int[] livGenero, string[] livTombo, string[] livCodBarra)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                MySqlDataReader Lendo = InstrucaoSQL("select * from livros;", Conexao).ExecuteReader();
                int count = 0;
                while (Lendo.Read())
                {
                    livNumCod[count] = Lendo.GetInt32(0);
                    livCodigo[count] = Lendo.GetString(1);
                    livNome[count] = Lendo.GetString(2);
                    livGenero[count] = int.Parse(Lendo.GetString(3));
                    livAutor[count] = Lendo.GetString(4);
                    livTombo[count] = Lendo.GetString(5);
                    livCodBarra[count] = Lendo.GetString(6);
                    count++;
                }
                Lendo.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        public void ImportandoBanco(int[] livNumCod, string[] livCodigo, string[] livNome, string[] livAutor, int[] livGenero, string[] livTombo, string[] livCodBarra)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            try
            {
                Conexao.Open();
                MySqlDataReader Lendo = InstrucaoSQL("select * from  livros;", Conexao).ExecuteReader();
                int count = 0;
                while (Lendo.Read())
                {
                    livNumCod[count] = Lendo.GetInt32(0);
                    livCodigo[count] = Lendo.GetString(1);
                    livNome[count] = Lendo.GetString(2);
                    livGenero[count] = int.Parse(Lendo.GetString(3));
                    livAutor[count] = Lendo.GetString(4);
                    livTombo[count] = Lendo.GetString(5);
                    livCodBarra[count] = Lendo.GetString(6);
                    count++;
                }
                Lendo.Close();
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
        }
        //-------------------------------------indices -------------------------------------------------------------//
        public int indexLinha(string campo,string tabela)
        {
            Conexao = new MySqlConnection("server=localhost; user id=root;password=3991;database=biblioteca_monteiro");
            int count = 0;
            try
            {
                Conexao.Open();
                MySqlDataReader Lendo = InstrucaoSQL("select count("+campo+") as 'Número de Linha' from "+tabela+";", Conexao).ExecuteReader();
                while (Lendo.Read())
                {
                    count += Lendo.GetInt32(0);
                }
            }
            catch (MySqlException erro)
            {
                MensagemErro = erro.ToString();
            }
            Conexao.Close();
            return (count+1);
        }
    }
}