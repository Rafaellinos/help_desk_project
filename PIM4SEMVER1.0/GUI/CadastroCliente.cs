using System;
using System.Windows.Forms;
using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.BLL;

namespace PIM4SEMVER1._0.GUI
{
    public partial class CadastroCliente : Form
    {
        //camadas data transfer object, passa entre todas camadas
        CadastroClienteDTO dto = new CadastroClienteDTO();

        // apresenta a camada de negocio
        CadastroClienteBLL dll = new CadastroClienteBLL();

        //string auxiliar para verificar o nível de acesso do usuário atual
        private string nivelAcesso;

        public CadastroCliente(string nA)//recebe o nível do usuário atual como parâmetro
        {
            InitializeComponent();
            //torna o form fixo, não podendo mudar o size
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            nivelAcesso = nA;
        }


        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            cmbCPFeCNPJ.Items.Add("CPF");
            cmbCPFeCNPJ.Items.Add("CNPJ");

            cmbUF.Items.Add("SP");
            cmbUF.Items.Add("DF");
            cmbUF.Items.Add("RJ");

            
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnBuscarCadastro.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
            this.Close();
        }

        private void cmbCPFeCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void cmbUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtNumeroCPFouCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao deixa o usuario digitar "char" e deixa ele usar backspace
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))

            {
                e.Handled = true;
            }
            
        }

        public void limpar()
        {
            txtNumeroCliente1.Clear();
            txtNumeroCPFouCNPJ.Clear();
            txtCidade.Clear();
            txtNomeCliente.Clear();
            txtLogradouroCliente.Clear();
         
            txtComplementoCliente.Clear();
            txtCEP.Clear();
            txtBairroCliente.Clear();
            txtCelularCliente1.Clear();
            txtEmailCliente.Clear();
            txtNumCasa.Clear();
            cmbUF.SelectedIndex = -1;
            cmbCPFeCNPJ.SelectedIndex = -1;
            dto.ClienteId = 0;

            
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;

        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //deseja mesmo salvar ?
            DialogResult confirm = MessageBox.Show("Desaja mesmo salvar ? ", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                bool cpfoucnpjexiste = false;
                
                //abaixo são validação de campos
                if(cmbCPFeCNPJ.SelectedIndex == -1)
                {
                    MessageBox.Show("É necessário selecionar CPF/CNPJ para salvar","Aviso!");
                }
                else if(cmbUF.SelectedIndex== -1)
                {
                    MessageBox.Show("É necessário selecionar a UF","Aviso!");
                }
                else if (string.IsNullOrWhiteSpace(txtNomeCliente.Text)) 
                //funcao isnullorwhitespace verifica se o campo está null, vazio ou com espaços em branco
                {
                    MessageBox.Show("O campo do nome do cliente precisa ser preenchido","Aviso!");
                }
                else if(string.IsNullOrEmpty(txtNumeroCPFouCNPJ.Text))
                {
                    MessageBox.Show("O campo do número do CPF/CNPJ precisa ser preenchido","Aviso!");
                }
                else if(string.IsNullOrEmpty(txtLogradouroCliente.Text))
                {
                    MessageBox.Show("O campo endereço precisa ser preenchido","Aviso!");
                }
                else if(string.IsNullOrWhiteSpace (txtNumeroCliente1.Text))
                {
                    MessageBox.Show("O campo número de telefone precisa ser preenchido","Aviso!");
                }
                
                else
                {
                    //pega as informações e adiciona no objeto dto
                    dto.ClienteNome = txtNomeCliente.Text;
                    dto.ClienteFixo1 = txtNumeroCliente1.Text;
                    dto.ClienteCel1 = txtCelularCliente1.Text;
                    dto.ClienteEmail = txtEmailCliente.Text;

                    dto.ClienteCPF = txtNumeroCPFouCNPJ.Text;
                    dto.ClienteCNPJ = txtNumeroCPFouCNPJ.Text;

                    dto.ClienteEscolha = cmbCPFeCNPJ.SelectedItem.ToString();

                    dto.ClienteLogradouro = txtLogradouroCliente.Text;
                    dto.ClienteNcasa = txtNumCasa.Text;
                    dto.ClienteComplemento = txtComplementoCliente.Text;
                    dto.ClienteBairro = txtBairroCliente.Text;
                    dto.ClienteCidade = txtCidade.Text;
                    dto.ClienteUF = cmbUF.SelectedItem.ToString();
                    dto.ClienteCEP = txtCEP.Text;
                    //verifica se já existe
                    cpfoucnpjexiste = dll.CPFouCNPJexiste(txtNumeroCPFouCNPJ.Text);
                    if (cpfoucnpjexiste)
                    {
                        //caso exista, será dado o aviso
                        MessageBox.Show("CPF ou CNPJ já existe no sistema!", "Aviso!");
                    }
                    else
                    {
                        //validação do número de algarismos
                        if(cmbCPFeCNPJ.Text=="CPF")
                        {
                            if(txtNumeroCPFouCNPJ.Text.Length == 11)
                            {
                                dll.Inserirr(dto); //passa como parâmetro dto preenchido
                                MessageBox.Show("Cadastro realizado com sucesso!");
                                limpar();
                            }
                            else
                            {
                                MessageBox.Show("Digite um CPF válido","Aviso!");
                            }
                        }
                        if(cmbCPFeCNPJ.Text == "CNPJ")
                        {
                            if(txtNumeroCPFouCNPJ.Text.Length == 14)
                            {
                                dll.Inserirr(dto); //passa como parâmetro dto preenchido
                                MessageBox.Show("Cadastro realizado com sucesso!");
                                limpar();
                            }
                            else
                            {
                                MessageBox.Show("CNPJ precisa ter 14 algarismos","Aviso!");
                            }
                        }
                    }
                }
            }
            else
            {
                limpar();
            }
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Desaja mesmo limpar ? ", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if(confirm.ToString().ToUpper()=="YES")
            {
                limpar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Desaja mesmo alterar ? ", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                bool cpfoucnpjexiste = false;
                //abaixo são validação de campos
                if (cmbCPFeCNPJ.SelectedIndex == -1)
                {
                    MessageBox.Show("É necessário selecionar CPF/CNPJ para salvar", "Aviso!");
                }
                else if (cmbUF.SelectedIndex == -1)
                {
                    MessageBox.Show("É necessário selecionar a UF", "Aviso!");
                }
                else if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                //funcao isnullorwhitespace verifica se o campo está null, vazio ou com espaços em branco
                {
                    MessageBox.Show("O campo do nome do cliente precisa ser preenchido", "Aviso!");
                }
                else if (string.IsNullOrEmpty(txtNumeroCPFouCNPJ.Text))
                {
                    MessageBox.Show("O campo do número do CPF/CNPJ precisa ser preenchido", "Aviso!");
                }
                else if (string.IsNullOrEmpty(txtLogradouroCliente.Text))
                {
                    MessageBox.Show("O campo endereço precisa ser preenchido", "Aviso!");
                }
                else if (string.IsNullOrWhiteSpace(txtNumeroCliente1.Text))
                {
                    MessageBox.Show("O campo número de telefone precisa ser preenchido", "Aviso!");
                }
                else
                {
                    //cpfoucnpjexiste = dll.CPFouCNPJexiste(txtNumeroCPFouCNPJ.Text);
                    if (cpfoucnpjexiste)
                    {
                        //caso exista, será dado o aviso
                        MessageBox.Show("CPF ou CNPJ já existe no sistema!", "Aviso!");
                    }
                    else
                    {
                        dto.ClienteNome = txtNomeCliente.Text;
                        dto.ClienteFixo1 = txtNumeroCliente1.Text;
                        dto.ClienteEmail = txtEmailCliente.Text;
                        dto.ClienteCel1 = txtCelularCliente1.Text;
                        dto.ClienteLogradouro = txtLogradouroCliente.Text;
                        dto.ClienteNcasa = txtNumCasa.Text;
                        dto.ClienteComplemento = txtComplementoCliente.Text;
                        dto.ClienteBairro = txtBairroCliente.Text;
                        dto.ClienteCidade = txtCidade.Text;
                        dto.ClienteUF = cmbUF.SelectedItem.ToString();
                        dto.ClienteCEP = txtCEP.Text;
                        if(cmbCPFeCNPJ.Text == "CPF")
                        {
                            dto.ClienteCPF = txtNumeroCPFouCNPJ.Text;
                        }
                        else if(cmbCPFeCNPJ.Text == "CNPJ")
                        {
                            dto.ClienteCNPJ = txtNumeroCPFouCNPJ.Text;
                        }
                        
                        dll.Atualizarr(dto);
                        MessageBox.Show("Cadastro Alterado com Sucesso!", "Aviso");
                        limpar();
                    }
                }
            }
            else
            {
                limpar();
            } 
        }

        private void btnBuscarCadastro_Click(object sender, EventArgs e)
        {    
            
            dto = dll.Buscarr(txtNumeroCPFouCNPJ.Text, cmbCPFeCNPJ.SelectedItem.ToString());
            if(string.IsNullOrWhiteSpace(txtNumeroCPFouCNPJ.Text))
            {
                MessageBox.Show("Digite o numero do CPF ou CMPJ","Aviso!");
            }
            else if (dto.ClienteSituacao == "ativado") 
                //verifica se o cliente é ativado, se for exibe no txtbox
            {



                txtNomeCliente.Text = dto.ClienteNome;
                txtNumeroCliente1.Text = dto.ClienteFixo1;
                txtCelularCliente1.Text = dto.ClienteCel1;
                txtEmailCliente.Text = dto.ClienteEmail;
                txtLogradouroCliente.Text = dto.ClienteLogradouro;
                txtNumCasa.Text = dto.ClienteNcasa;
                txtComplementoCliente.Text = dto.ClienteComplemento;
                txtBairroCliente.Text = dto.ClienteBairro;
                txtCidade.Text = dto.ClienteCidade;
                cmbUF.Text = dto.ClienteUF;
                txtCEP.Text = dto.ClienteCEP;
                txtNumeroCPFouCNPJ.Text = dto.ClienteCPF;
            }
            else if(dto.ClienteSituacao == "desativado")
                //verifica se o cliente esta desativa, se estiver tem a opcao de ativar
            {
                DialogResult AtivarCliente = MessageBox.Show("Cliente desativado!\nDeseja ativar o cliente ?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if(AtivarCliente.ToString().ToUpper()=="YES")
                {
                    if(nivelAcesso == "Admin")
                        //apenas admin podem ativar cliente assim como excluir
                    {
                        dll.AtivarCliente(dto.ClienteId);
                        MessageBox.Show("Cliente ativado com sucesso!","Aviso!");

                        txtNomeCliente.Text = dto.ClienteNome;
                        txtNumeroCliente1.Text = dto.ClienteFixo1;
                        txtCelularCliente1.Text = dto.ClienteCel1;
                        txtEmailCliente.Text = dto.ClienteEmail;
                        txtLogradouroCliente.Text = dto.ClienteLogradouro;
                        txtNumCasa.Text = dto.ClienteNcasa;
                        txtComplementoCliente.Text = dto.ClienteComplemento;
                        txtBairroCliente.Text = dto.ClienteBairro;
                        txtCidade.Text = dto.ClienteCidade;
                        cmbUF.Text = dto.ClienteUF;
                        txtCEP.Text = dto.ClienteCEP;
                        txtNumeroCPFouCNPJ.Text = dto.ClienteCPF;
                    }
                    else
                    {
                        MessageBox.Show("Somente administradores podem ativar ou desativar clientes!","Aviso!");
                        limpar();
                    }
                }
                
                //limpar();
            }
            else
            //se não for ativo ou desativado significa que o cliente não existe no sistema
            {
                MessageBox.Show("Cliente não cadastrado!","Aviso!");
                
            }
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //antes de excluir um funcionário, verifica se é admin, pois apenas admin pode excluir
            
            if (nivelAcesso == "Admin")
            {
                DialogResult confirm = MessageBox.Show("Desaja mesmo excluir ? ", "Excluir", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                
                if (confirm.ToString().ToUpper() == "YES")
                {
                    dll.Excluirr(dto);
                    MessageBox.Show("Cadastro Excluido com sucesso!", "Aviso");
                    limpar();
                }
            }
            else
            {
                MessageBox.Show("Somente administradores podem excluir clientes!","Aviso!");
            }
        }

        private void cmbCPFeCNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnBuscarCadastro.Enabled = true;
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)))

            {
                e.Handled = true;
            }
        }

        private void msVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msAjuda_Click(object sender, EventArgs e)
        {
            new AjudaCadastroCliente().ShowDialog();
        }

        private void lupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como Operar a LUPA:\n\nSeta pra cima aumenta\nSeta para baixo diminui\nESC volta");
            new lupa().ShowDialog();
        }
    }
}
