namespace PIM4SEMVER1._0.DTO
{
    class CadastroFuncionarioDTO
    {
        private string funcID;
        private string funcNome;
        private string funcCPF;
        private string funcTelefone;
        private string funcEmail;
        private string funcAdmissao;
        private string funcDeficiente;
        private string funcSituacao;
        private string usuario;
        private string senha;
        private string cargo;
        private string newCPF;


        public string FuncNome { get => funcNome; set => funcNome = value; }
        public string FuncCPF { get => funcCPF; set => funcCPF = value; }
        public string FuncTelefone { get => funcTelefone; set => funcTelefone = value; }
        public string FuncEmail { get => funcEmail; set => funcEmail = value; }
        public string FuncAdmissao { get => funcAdmissao; set => funcAdmissao = value; }
        public string FuncID { get => funcID; set => funcID = value; }
        public string FuncDeficiente { get => funcDeficiente; set => funcDeficiente = value; }
        public string FuncSituacao { get => funcSituacao; set => funcSituacao = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string NewCPF { get => newCPF; set => newCPF = value; }
    }
}