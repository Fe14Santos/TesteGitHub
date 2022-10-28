namespace BibliotecaMonteiroLobato
{
    class Usuario
    {
        int[] usuCodigo = new int[10];
        string[] usuNome = new string[10];
        string[] usuCpf = new string[10];
        string[] usuSenha = new string[10];

        public int[] Codigo
        {
            get { return usuCodigo; }
            set { usuCodigo = value; }
        }
        public string [] Nome
        {
            get { return usuNome; }
            set { usuNome = value; }
        }
        public string[] CPF
        {
            get { return usuCpf; }
            set { usuCpf = value; }
        }
        public string[] Senha
        {
            get { return usuSenha; }
            set { usuSenha = value; }
        }
    }
}