using System;
using System.Windows.Forms;
using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.BLL;

namespace PIM4SEMVER1._0.GUI
{
    public partial class BuscaCliente : Form
    {
        ChamadosDTO dtoChamado = new ChamadosDTO();
        AberturaChamado destino;
        private string usuarioA;

        ChamadoBLL ChamadoBLL = new ChamadoBLL();

        public BuscaCliente(string usuario)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            usuarioA = usuario;

            btnAlterar.Enabled = false;
        }

        public void limpar()
        {
            rbCPFchamado.Enabled = true;
            rbCNPJchamado.Enabled = true;
            rbCNPJchamado.Checked = false;
            rbCPFchamado.Checked = false;
            txtCNPJchamado.Text = string.Empty;
            DGVprotocolos.DataSource = null;
            txtCPFchamado.Text = string.Empty;
            dtoChamado.ChamadoCNPJ = string.Empty;
            dtoChamado.ChamadoCPF = string.Empty;
            txtCNPJchamado.Enabled = false;
            txtCPFchamado.Enabled = false;
            btnAlterar.Enabled = false;

        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //verifica se é cpf ou cnpj
            if (txtCPFchamado.Text.Length == 11)
            {
                //validação de campo
                if (string.IsNullOrWhiteSpace(txtCPFchamado.Text))
                {
                    MessageBox.Show("CPF inválido!", "Aviso!");
                    limpar();
                }
                else
                {
                    //desabilita os comando de cpf e cnpj
                    //faz a busca dos chamados relacionados a um determinado cliente
                    txtCPFchamado.Enabled = false;
                    btnAlterar.Enabled = true;
                    rbCNPJchamado.Enabled = false;
                    dtoChamado.ChamadoCPF = txtCPFchamado.Text;
                    dtoChamado.ChamadoCNPJ = string.Empty;


                    DGVprotocolos.DataSource = null;
                    DGVprotocolos.DataSource = ChamadoBLL.BuscarChamado(dtoChamado);
                    //esconde cpf e descrição para diminuir o tamanho do gridview, porém as informações serão usadas se
                    //o usuário clicar em altear
                    DGVprotocolos.Columns[0].Width = 30;
                    DGVprotocolos.Columns[7].Visible = false;
                    DGVprotocolos.Columns[8].Visible = false;
                    DGVprotocolos.Columns[10].Visible = false;
                    DGVprotocolos.Columns[11].Width = 42;
                    DGVprotocolos.Refresh();

                    if (DGVprotocolos.RowCount == 0)
                    {
                        //se a busca nao retornar nenhuma linha
                        MessageBox.Show("CPF não cadastrado ou não possuí chamados relacionados", "Aviso!");
                        limpar();
                    }
                }
            }
            else if (txtCNPJchamado.Text.Length == 14)
            {
                if (string.IsNullOrWhiteSpace(txtCNPJchamado.Text))
                {
                    MessageBox.Show("CPNJ inválido", "Aviso!");
                    limpar();
                }
                else
                {
                    //desabilita os comando de cpf e cnpj
                    btnAlterar.Enabled = true;
                    rbCPFchamado.Enabled = false;
                    txtCPFchamado.Enabled = false;
                    
                    txtCNPJchamado.Enabled = false;
                    dtoChamado.ChamadoCPF = string.Empty;
                    dtoChamado.ChamadoCNPJ = txtCNPJchamado.Text;
                    dtoChamado.ChamadoCPF = string.Empty;


                    DGVprotocolos.DataSource = null;
                    DGVprotocolos.DataSource = ChamadoBLL.BuscarChamado(dtoChamado);
                    //faz a busca
                    DGVprotocolos.Columns[0].Width = 30; //ajuda tamanho da célula
                    DGVprotocolos.Columns[7].Visible = false;//torna invisivel campos que n sao necessários
                    DGVprotocolos.Columns[8].Visible = false;
                    DGVprotocolos.Columns[10].Visible = false;
                    DGVprotocolos.Columns[11].Width = 42;
                    DGVprotocolos.Refresh();

                    if (DGVprotocolos.RowCount == 0)
                    {
                        //se a busca não retornar nenhuma linha
                        MessageBox.Show("CNPJ não cadastrado ou não possuí chamados relacionados", "Aviso!");
                        limpar();
                    }
                }
            }
            else
            {
                MessageBox.Show("CPF ou CNPJ inválido");
                limpar();
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbCPFchamado_CheckedChanged(object sender, EventArgs e)
        {
            txtCPFchamado.Enabled = true;
            txtCNPJchamado.Enabled = false;
            txtCNPJchamado.Text = string.Empty;
        }

        private void rbCNPJchamado_CheckedChanged(object sender, EventArgs e)
        {
            txtCNPJchamado.Enabled = true;
            txtCPFchamado.Enabled = false;
            txtCPFchamado.Text = string.Empty;
        }

       

        private void txtCPFchamado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))

            {
                e.Handled = true;
            }

        }

        private void txtCNPJchamado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))

            {
                e.Handled = true;
            }
        }

        private void capturaDto ()
        {
            //pega a linha selecionada e carrega no objeto para a tela Alterar Chamado
            int g = 0;
            g = DGVprotocolos.CurrentRow.Index;

            dtoChamado.ChamadoProtocolo = Convert.ToInt32(DGVprotocolos.Rows[g].Cells[0].Value.ToString());
            dtoChamado.ChamadoNomeCliente = DGVprotocolos.Rows[g].Cells[1].Value.ToString();
            dtoChamado.ChamadoData = DGVprotocolos.Rows[g].Cells[2].Value.ToString();
            dtoChamado.ChamadaHora = DGVprotocolos.Rows[g].Cells[3].Value.ToString();
            dtoChamado.ChamadoNomeEqui = DGVprotocolos.Rows[g].Cells[4].Value.ToString();
            dtoChamado.ChamadoResumo = DGVprotocolos.Rows[g].Cells[5].Value.ToString();
            dtoChamado.ChamadoNomeFunc = DGVprotocolos.Rows[g].Cells[6].Value.ToString();
            dtoChamado.ChamadoDescricao = DGVprotocolos.Rows[g].Cells[7].Value.ToString();
            dtoChamado.ChamadoLocal = DGVprotocolos.Rows[g].Cells[10].Value.ToString();
            
            if (rbCPFchamado.Checked)
            {
                dtoChamado.ChamadoCNPJ = string.Empty;
                dtoChamado.ChamadoCPF = DGVprotocolos.Rows[g].Cells[8].Value.ToString();
            }
            else if (rbCNPJchamado.Checked)
            {
                dtoChamado.ChamadoCPF = string.Empty;
                dtoChamado.ChamadoCNPJ = DGVprotocolos.Rows[g].Cells[8].Value.ToString();
            }
            dtoChamado.ChamadoSituacao = DGVprotocolos.Rows[g].Cells[9].Value.ToString();

            dtoChamado.ChamadoVisita = DGVprotocolos.Rows[g].Cells[11].Value.ToString();

            if (dtoChamado.ChamadoSituaCliente == "desativado")
            {
                MessageBox.Show("Cliente desativado, contacte o administrador do sistema", "Aviso!");

            }
            else
            {
                destino = new AberturaChamado(dtoChamado,usuarioA);
                destino.Text = "Alterar Chamado";
                limpar();
                destino.ShowDialog();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (rbCPFchamado.Checked)
            {
                dtoChamado = ChamadoBLL.BuscarCliente(txtCPFchamado.Text);

                if (string.IsNullOrWhiteSpace(txtCPFchamado.Text))
                {
                    MessageBox.Show("Digite um CPF", "Aviso!");
                }
                else if (DGVprotocolos.RowCount == 0)
                {
                    MessageBox.Show("CPF ou CNPJ inváldo!", "Aviso!");
                }
                else
                {
                    capturaDto();
                }

            }
            else if (rbCNPJchamado.Checked)
            {
                dtoChamado = ChamadoBLL.BuscarCliente(txtCNPJchamado.Text);

                if (string.IsNullOrWhiteSpace(txtCNPJchamado.Text))
                {
                    MessageBox.Show("Digite um CNPJ", "Aviso!");

                }

                else if (DGVprotocolos.RowCount == 0)
                {
                    MessageBox.Show("CPF ou CNPJ inváldo!", "Aviso!");
                }

                else
                {
                    capturaDto();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();   
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AjudaBuscarChamado().ShowDialog();
        }
    }



}
