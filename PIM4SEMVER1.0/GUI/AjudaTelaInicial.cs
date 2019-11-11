using System;
using System.Windows.Forms;

namespace PIM4SEMVER1._0.GUI
{
    public partial class AjudaTelaInicial : Form
    {
        public AjudaTelaInicial()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void AjudaTelaInicial_Load(object sender, EventArgs e)
        {
            lblAjuda.Text = "Tela inicial: O funcionário só tem acesso as funções: \nAbrir chamado > Buscar chamado > Cadastrar cliente > Relogar > Ver os Últimos Chamados." +
                "\nO gráfico mostra os chamados abertos(azul) e fechados(verde)." +
                "\nÚltimos Chamados: Carrega três chamados abertos(sem solução) mais antigos no sistema." +
                "\nClicando em Ver Chamado será direcionado a tela do chamado respectivo.";
        }
    }
}
