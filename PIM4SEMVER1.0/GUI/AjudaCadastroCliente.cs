using System;
using System.Windows.Forms;

namespace PIM4SEMVER1._0.GUI
{
    public partial class AjudaCadastroCliente : Form
    {
        public AjudaCadastroCliente()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void AjudaCadastroCliente_Load(object sender, EventArgs e)
        {
            lblAjuda.Text = "Para cadastrar o Cliente você deve preencher os campos:" +
                "\nNome > CPF/CNPJ > Número > Endereço > Cidade > Bairro > E-mail > Telefone fixo > Telefone Celular > “Salvar”" +
                "\nPara buscar um Cliente você deve informar o campo CPF/CNPJ, em seguida clicar no botão “Buscar Cadastro”." +
                "\nCaso o CPF/CNPJ informado estiver desativado, o sistema exibirá a mensagem “Cadastro desativado! Deseja Reativar?"+
                "\nPara alterar os dados de um Cliente você deve informar o CPF/CNPJ depois clicar em “Alterar”. " +
                "\nEm seguida o sistema irá exibir a seguinte mensagem “Deseja mesmo alterar?”" +
                "\nPara excluir um Cliente você deve informar o CPF ou CNPJ depois clicar em “Excluir”" +
                "\nO sistema irá exibir a seguinte mensagem “Deseja mesmo excluir?”";
                
        }
    }
}
