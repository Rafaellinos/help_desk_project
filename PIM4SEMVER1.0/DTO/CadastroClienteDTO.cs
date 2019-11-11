namespace PIM4SEMVER1._0.DTO
{
    public class CadastroClienteDTO
    {
        //data transfer object = dados que serão tranferidos, pode percorrer DAL, BLL e GUI livrimente
        private string clienteNome;
        private string clienteCPF;
        private string clienteCNPJ;
        private string clienteCidade;
        private string clienteUF;
        private string clienteCEP;
        private string clienteComplemento;
        private string clienteLogradouro;
        private string clienteBairro;
        private string clienteEmail;
        private string clienteFixo1;
        private string clienteCel1;
        private string clienteNcasa;
        private string clienteEscolha;
        private string escolha;
        private int clienteId;
        private string clienteSituacao;
        private string funcUsu;
        private string clienteNewCpfCnpj;
        


        public string ClienteNome { get => clienteNome; set => clienteNome = value; }
        public string ClienteCPF { get => clienteCPF; set => clienteCPF = value; }
        public string ClienteCidade { get => clienteCidade; set => clienteCidade = value; }
        public string ClienteUF { get => clienteUF; set => clienteUF = value; }
        public string ClienteCEP { get => clienteCEP; set => clienteCEP = value; }
        public string ClienteComplemento { get => clienteComplemento; set => clienteComplemento = value; }
        public string ClienteLogradouro { get => clienteLogradouro; set => clienteLogradouro = value; }
        public string ClienteBairro { get => clienteBairro; set => clienteBairro = value; }
        public string ClienteEmail { get => clienteEmail; set => clienteEmail = value; }
        public string ClienteFixo1 { get => clienteFixo1; set => clienteFixo1 = value; }
        public string ClienteCel1 { get => clienteCel1; set => clienteCel1 = value; }
        public string ClienteCNPJ { get => clienteCNPJ; set => clienteCNPJ = value; }
        public string ClienteNcasa { get => clienteNcasa; set => clienteNcasa = value; }
        public string ClienteEscolha { get => clienteEscolha; set => clienteEscolha = value; }
        public string Escolha { get => escolha; set => escolha = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public string ClienteSituacao { get => clienteSituacao; set => clienteSituacao = value; }
        public string FuncUsu { get => funcUsu; set => funcUsu = value; }
        public string ClienteNewCpfCnpj { get => clienteNewCpfCnpj; set => clienteNewCpfCnpj = value; }
    }
}
