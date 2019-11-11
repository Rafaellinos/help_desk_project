using System;
using System.Windows.Forms;
using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.BLL;
namespace PIM4SEMVER1._0.GUI
{
    public partial class AberturaChamado : Form
    {
       
        ChamadosDTO dtoChamado = new ChamadosDTO();
        ChamadoBLL ChamadoBLL = new ChamadoBLL();


        public string usuario; //variavel auxiliar para identificar o usuario logado
        public string usuarioA;
        public string nivelAcesso;

        public AberturaChamado(string usu, string nivelacesso)
        {
            //recebe como parâmetro o usuário logado, para relacionar ao chamado
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            usuario = usu;
            nivelAcesso = nivelacesso;
            txtProtocolo.TabIndex = 0;
            cbCategoria.Items.Add("Desktop");
            cbCategoria.Items.Add("Notebook");
            cbCategoria.Items.Add("Periféricos");

            cbSituacao.Items.Add("Aberto");
            cbSituacao.Items.Add("Fechado");

            txtResumoChamado.Enabled = false;
            txtDescricao.Enabled = false;
            cbCategoria.Enabled = false;
            cbModelo.Enabled = false;
            cbSituacao.Enabled = false;
            btnSalvar.Enabled = false;

            rbVisitaNao.Enabled = false;
            rbVisitaSim.Enabled = false;

            btnAlterar.Visible = false;

            

        }

        public AberturaChamado(ChamadosDTO dto,string usuarioB)
        {
            //recebe como parâmetro o DTO de chamados vindo da tela de buscar chamados
            //carrega as informações do chamado que foi selecionado na tela buscar chamados
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            txtDescricao.TabIndex = 0;//Jogo o focus para o txtDescricao

            usuarioA = usuarioB;

            txtProtocolo.TabIndex = 0;

            btnSalvar.Visible = false;
            btnLimpar.Visible = false;
            

            cbCategoria.Items.Add("Desktop");
            cbCategoria.Items.Add("Notebook");
            cbCategoria.Items.Add("Periféricos");

            cbSituacao.Items.Add("Aberto");
            cbSituacao.Items.Add("Fechado");



            txtProtocolo.Text = Convert.ToString(dto.ChamadoProtocolo); //carrega as informações do chamado
            txtNomeCliente.Text = dto.ChamadoNomeCliente;
            txtResumoChamado.Text = dto.ChamadoResumo;

            cbSituacao.Text = dto.ChamadoSituacao;

            cbModelo.Text = dto.ChamadoNomeEqui;

            if(dto.ChamadoVisita == "Sim")
            {
                rbVisitaSim.Checked = true;
                rbVisitaNao.Checked = false;
            }
            else if(dto.ChamadoVisita == "Não")
            {
                rbVisitaSim.Checked = false;
                rbVisitaNao.Checked = true;
            }

            //verifica se é cpnj
            if (dto.ChamadoCPF.Length == 11)
            {
                txtCPFchamado.Text = dto.ChamadoCPF;
            }
            else if(dto.ChamadoCPF.Length == 14)
            {
                txtCNPJchamado.Text = dto.ChamadoCPF;
            }

            else if(dto.ChamadoCNPJ.Length == 14)
            {
                txtCNPJchamado.Text = dto.ChamadoCNPJ;

            }


            cbCategoria.Enabled = false; //Desabilita combobox de categoria e modelo, pois cada chamado só terá um equipamento relacionado
            cbModelo.Enabled = false;
            rbVisitaNao.Enabled = false;
            rbVisitaSim.Enabled = false;
            /*Carrega as informações como data, hora e nome do funcionário que deu entrada no chamado, 
            assim que alterado por um funcionário, essas informações originais da abertura ficarão gravadas na descrição do chamado.*/

            txtDescricao.Text += dto.ChamadoDescricao + " \n\n\nNome do Funcionário que abriu o chamado: " + dto.ChamadoNomeFunc + "\nData e hora em que o chamado foi efetuado: "
                + dto.ChamadoData.Replace("00:00:00", " ") + dto.ChamadaHora;
             

            
        }


        private void rbCNPJchamado_CheckedChanged(object sender, EventArgs e)
        {
            txtCNPJchamado.Enabled = true;
            txtCPFchamado.Enabled = false;
            txtCPFchamado.Text = string.Empty;
        }

        private void rbCPFchamado_CheckedChanged(object sender, EventArgs e)
        {
            txtCPFchamado.Enabled = true;
            txtCNPJchamado.Enabled = false;
            txtCNPJchamado.Text = string.Empty;
        }
        private void limparDtoChamado()
        {
            //limpa o objeto DTO do chamado caso o cliente esteja desativado no sistema para não gerar conflito
            MessageBox.Show("Cliente desativado, contacte o administrador do sistema", "Aviso!");
            
            dtoChamado.ChamadoSituaCliente = string.Empty;
            dtoChamado.ChamadoRuaCliente = string.Empty;
            dtoChamado.ChamadoNumeroRuaCliente = string.Empty;
            dtoChamado.ChamadoIdCliente = 0;
            dtoChamado.ChamadoNomeCliente = string.Empty;
            limpar();
            
            
        }

        private void txtCPFchamado_TextChanged(object sender, EventArgs e)
        {
            string cpf;
            cpf = txtCPFchamado.Text;
            if (cpf.Length == 11) //cpf contem 11
            {
                dtoChamado.ChamadoCPF = cpf;

                dtoChamado = ChamadoBLL.BuscarCliente(cpf); //verifica status do cliente

                if (dtoChamado.ChamadoSituaCliente == "desativado")
                    //caso cliente desativado
                {
                    limparDtoChamado();
                }
                else
                {
                    txtNomeCliente.Text = dtoChamado.ChamadoNomeCliente;
                    txtLocal.Text = dtoChamado.ChamadoRuaCliente + ", " + dtoChamado.ChamadoNumeroRuaCliente;

                    if(string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                    {
                        DialogResult confirm = MessageBox.Show("CPF não cadastrado.\nDeseja cadastrar ? ", "Limpar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        if (confirm.ToString().ToUpper() == "YES")
                        {
                            //se o cpf nao estiver cadastrado, pergunta se usuário deseja cadastrar
                            new CadastroCliente(nivelAcesso).ShowDialog();
                        }
                        limpar();
                    }
                }
            }


        }

        private void txtCNPJchamado_TextChanged(object sender, EventArgs e)
        {
            string CNPJ;
            CNPJ = txtCNPJchamado.Text;


            if (CNPJ.Length == 14) // cnpj tem 14 caracteres
            {
                dtoChamado.ChamadoCNPJ = CNPJ;

                dtoChamado = ChamadoBLL.BuscarCliente(CNPJ);

                if (dtoChamado.ChamadoSituaCliente == "desativado")
                {
                    limparDtoChamado();
                }
                else
                {
                    txtNomeCliente.Text = dtoChamado.ChamadoNomeCliente;
                    txtLocal.Text = dtoChamado.ChamadoRuaCliente + ", " + dtoChamado.ChamadoNumeroRuaCliente;
                    if(string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                    {
                        if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                        {
                            DialogResult confirm = MessageBox.Show("CNPJ não cadastrado.\nDeseja cadastrar ? ", "Limpar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                            if (confirm.ToString().ToUpper() == "YES")
                            {
                                //se o cpf nao estiver cadastrado, pergunta se usuário deseja cadastrar
                                new CadastroCliente(nivelAcesso).ShowDialog();
                            }
                            limpar();
                        }
                    }

                }
                
            }

        }

        private void Limparcbs()
        {
            cbModelo.DataSource = null; //limpa combobox

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem.ToString() == "Desktop")
            {
                Limparcbs();
                cbModelo.DataSource = ChamadoBLL.fillCombo(1);
            }
            else if (cbCategoria.SelectedItem.ToString() == "Notebook")
            {
                Limparcbs();
                cbModelo.DataSource = ChamadoBLL.fillCombo(2);

            }
            else if (cbCategoria.SelectedItem.ToString() == "Periféricos")
            {
                Limparcbs();
                cbModelo.DataSource = ChamadoBLL.fillCombo(3);
            }
            else
            {

                Limparcbs();
            }
        }


        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSituacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //validação de campos antes de salvar
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria", "Aviso!");
            }
            else if (cbSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a situação do chamado (aberto ou fechado)", "Aviso!");
            }
            else if (string.IsNullOrWhiteSpace(txtResumoChamado.Text))
            {
                MessageBox.Show("Resumo não pode ficar em branco", "Aviso!");
            }
            else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Descrição do chamado não pode ficar em branco!", "Aviso!");
            }
            else if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Cliente não encontrado\nDigite um CPF ou CNPJ válido", "Aviso!");
            }
            else
            {
                int protocolo;
                //pega a data e hora atual
                DateTime Today = DateTime.Now;
                DateTime Hour = DateTime.Now;

                if(rbVisitaSim.Checked)
                {
                    dtoChamado.ChamadoVisita = "Sim";
                }
                else if(rbVisitaNao.Checked)
                {
                    dtoChamado.ChamadoVisita = "Não";
                }
                else
                {
                    MessageBox.Show("Especifique se haverá visita","Aviso!");
                }
                dtoChamado.ChamadoDescricao = txtDescricao.Text;
                dtoChamado.ChamadoNomeCliente = txtNomeCliente.Text;
                dtoChamado.ChamadoNomeFunc = ChamadoBLL.NomeFuncionario(usuario); //pega o nome do funcionario apartir do seu login
                dtoChamado.ChamadoData = Today.ToString("yyyy-MM-dd"); //edita o formato da data
                dtoChamado.ChamadaHora = Hour.ToString("HH:mm"); //edita o formato da hora
                dtoChamado.ChamadoIDfunci = ChamadoBLL.IDusuario(usuario); //pega o id do usuario apartir do seu login
                dtoChamado.ChamadoSituacao = cbSituacao.Text; 
                dtoChamado.ChamadoResumo = txtResumoChamado.Text;
                dtoChamado.ChamadoLocal = txtLocal.Text;

                dtoChamado.ChamadoNomeEqui = cbModelo.SelectedItem.ToString();

                dtoChamado.ChamadoProtocolo = ChamadoBLL.Inserir(dtoChamado); //insere os dados no banco e retorna o protocolo para o usuário informar o cliente
                protocolo = dtoChamado.ChamadoProtocolo;
                MessageBox.Show("Chamado salvo com sucesso, o numero do protocolo salvo: " + protocolo + " "); //mostra o protocolo
                limpar();
            }

        }

       

        private void limpar()
        {
            //limpa campos
            if (rbCPFchamado.Enabled != true)
            {
                rbCPFchamado.Enabled = true;
            }
            if (rbCNPJchamado.Enabled != true)
            {
                rbCNPJchamado.Enabled = true;
            }
            //cbCategoria.SelectedIndex = -1;
            dtoChamado.ChamadoProtocolo = 0;
            cbModelo.DataSource = null;
            cbSituacao.SelectedIndex = -1;
            rbCNPJchamado.Checked = false;
            rbCPFchamado.Checked = false;
            txtCPFchamado.Clear();
            txtCNPJchamado.Clear();
            txtDescricao.Clear();
            txtLocal.Clear();
            txtProtocolo.Clear();
            txtResumoChamado.Clear();
            txtNomeCliente.Clear();
            txtCPFchamado.Enabled = false;
            txtCNPJchamado.Enabled = false;
            rbVisitaNao.Enabled = false;
            rbVisitaSim.Enabled = false;

            txtResumoChamado.Enabled = false;
            txtDescricao.Enabled = false;
            cbCategoria.Enabled = false;
            cbModelo.Enabled = false;
            cbSituacao.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //pega data e hora atual
            DateTime Today = DateTime.Now;
            DateTime Hour = DateTime.Now;

            dtoChamado.ChamadoData = Today.ToString("yyyy-MM-dd");
            dtoChamado.ChamadaHora = Hour.ToString("HH:mm");
            dtoChamado.ChamadoCPF = txtCPFchamado.Text;
            dtoChamado.ChamadoCNPJ = txtCNPJchamado.Text;
            dtoChamado.ChamadoNomeFunc = ChamadoBLL.NomeFuncionario(usuarioA);
            dtoChamado.ChamadoIDfunci = ChamadoBLL.IDusuario(usuarioA);
            dtoChamado.ChamadoNumeroRuaCliente = txtLocal.Text;
            dtoChamado.ChamadoDescricao = txtDescricao.Text;
            dtoChamado.ChamadoResumo = txtResumoChamado.Text;
            dtoChamado.ChamadoSituacao = cbSituacao.Text;
            dtoChamado.ChamadoLocal = txtLocal.Text; //Adicionado
            dtoChamado.ChamadoProtocolo = Convert.ToInt32(txtProtocolo.Text);

            ChamadoBLL.AlterarChamado(dtoChamado);

            MessageBox.Show("Cadastro Alterado com sucesso!", "Aviso");
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {

            }
            else
            {
                rbCPFchamado.Enabled = false;
                rbCNPJchamado.Enabled = false;
                txtCPFchamado.Enabled = false;
                txtCPFchamado.Enabled = false;
                txtResumoChamado.Enabled = true;
                txtDescricao.Enabled = true;
                cbCategoria.Enabled = true;
                cbModelo.Enabled = true;
                cbSituacao.Enabled = true;
                btnSalvar.Enabled = true;
                rbVisitaNao.Enabled = true;
                rbVisitaSim.Enabled = true;
            }
        }

        private void msLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void msVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msAjuda_Click(object sender, EventArgs e)
        {
            new AjudaGerenciamentoChamado().ShowDialog();
        }

        private void lupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como Operar a LUPA:\n\nSeta pra cima aumenta\nSeta para baixo diminui\nESC volta");
            new lupa().ShowDialog();
        }
    }
}
