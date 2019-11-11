using System;
using System.Windows.Forms;

namespace PIM4SEMVER1._0.GUI
{
    public partial class AjudaBuscarChamado : Form
    {
        public AjudaBuscarChamado()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        private void AjudaBuscarChamado_Load(object sender, EventArgs e)
        {
            lblAjuda.Text = "Para buscar um chamado e alterar você deverá informar CPF/CNPJ e clicar em “Confirmar”. " +
                "\nLogo após você terá que selecionar o chamado que deseja modificar e clicar em “Alterar”, " +
                "\nem seguida você será direcionado para a tela de Alteração de chamado. " +
                "\nCaso o CPF/CNPJ não esteja cadastrado ou não possua chamados a seguinte mensagem será mostrada: " +
                "\n“CPF não cadastrado ou não possui chamados relacionados”";
        }
    }
}
