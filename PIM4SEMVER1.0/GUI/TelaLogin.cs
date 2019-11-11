using System;
using System.Windows.Forms;
using PIM4SEMVER1._0.BLL;
using PIM4SEMVER1._0.DTO;


namespace PIM4SEMVER1._0
{
    public partial class TelaLogin : Form
    {
        public string usua;
        public string usu, senh;

        private bool result = false;
        private bool checkStatus = false;
        LoginBLL bll = new LoginBLL();
        CadastroClienteDTO dto = new CadastroClienteDTO();
        
        public TelaLogin()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            txtusuario.TabIndex = 0; //ordem do tab e do focus
            txtsenha.TabIndex = 1;
            

        }
        private void limpar()
        {
            txtusuario.Text = string.Empty; //limpa campos
            txtsenha.Text = string.Empty;
        }
        
        public void Log()
        {

            //atribui txt as strings
            usu = txtusuario.Text;
            senh = txtsenha.Text;

            
            result = bll.Logiin(usu, senh); //verifica no banco se existe, se existir o result é true, se não é falso
            checkStatus = bll.CheckStatus(usu); //se for falso, funcionario está desativado e portanto nao podera logar, se true, poderá logar
            if (!result)
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
            else if (checkStatus == false)
            {
                MessageBox.Show("Funcionário desativado. Contacte o administrador do sistema", "Aviso!");
                limpar();
            }
            else if (result && checkStatus)
            {
                
                //usua = usu;
                DialogResult = DialogResult.OK;
                //se result for verdadeiro, dialog receberá ok, que por sua vez na classe program.cs se for == a ok abrirá a tela principal
                

            }
        }
        
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //esse botao corresponde ao enter do teclado. Quando o usuário apertar enter estando no cursor usuario ou senha iniciara o evento de login
            {
                Log();
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Log();
            }
        }

        public void btnlog_Click(object sender, EventArgs e)
        {
            
                Log();
            
        }
    }
}
