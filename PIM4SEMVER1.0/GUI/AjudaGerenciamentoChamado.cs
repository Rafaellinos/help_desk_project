using System.Windows.Forms;

namespace PIM4SEMVER1._0.GUI
{
    public partial class AjudaGerenciamentoChamado : Form
    {
        public AjudaGerenciamentoChamado()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        private void AjudaGerenciamentoChamado_Load(object sender, System.EventArgs e)
        {
            lblAjuda.Text = "Para abertura de chamado você deve informar:\nCPF ou CNPJ > Categoria do equipamento > Modelo > " +
                "situação.\nAssim que o Cliente for encontrado será liberado o “Assunto” para descrever o problema." +
                "\nOs campos: Cliente > N° de protocolo > Local, serão preenchidos automaticamente\nCaso o CPF ou CNPJ não for " +
                "encontrado o sistema irá avisar.";
        }
    }
}
