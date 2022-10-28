namespace BibliotecaMonteiroLobato
{
    class Livros:Usuario
    {
        private int    [] liv_num_cod = new int[9999];
        private string [] liv_codigo = new string[9999];
        private string [] liv_nome = new string[9999];
        private string [] liv_autor = new string[9999];
        private string [] liv_tombo = new string[9999];
        private string [] liv_genero = new string[9999];
        private string [] gen_genero = new string[9999];
        private int    [] _intGenero = new int[9999];
        private string [] liv_cod_barras = new string[9999];

        public int[] Liv_Num_Cod
        {
            set { liv_num_cod = value; }
            get { return liv_num_cod; }
        }
        public string[] Liv_Codigo
        {
            set { liv_codigo = value; }
            get { return liv_codigo; }
        }
        public string[] Liv_Nome
        {
            set { liv_nome = value; }
            get { return liv_nome; }
        }
        public string[] Liv_Autor
        {
            set { liv_autor = value; }
            get { return liv_autor; }
        }
        public string[] Liv_Tombo
        {
            set { liv_tombo = value; }
            get { return liv_tombo; }
        }        
        public string[] Liv_Genero
        {
            set { liv_genero = value; }
            get { return liv_genero; }
        }
        public string[] Liv_Cod_Barras
        {
            set { liv_cod_barras = value; }
            get { return liv_cod_barras; }
        }
        public string[] Gen_Genero
        {
            set { gen_genero = value; }
            get { return gen_genero; }
        }
        public int[] intGenero
        {
            set { _intGenero = value; }
            get { return _intGenero; }
        }
    }
}
