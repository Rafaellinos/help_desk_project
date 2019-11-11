using PIM4SEMVER1._0.DTO;
using System;
using System.Windows.Forms;
using PIM4SEMVER1._0.BLL;

namespace PIM4SEMVER1._0.GUI
{
    public partial class CadastroFuncionario : Form
    {
        
        CadastroFuncionarioDTO funcDTO = new CadastroFuncionarioDTO();
        CadastroFuncionariosBLL funcBLL = new CadastroFuncionariosBLL();


        public CadastroFuncionario()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e) //botão salvar
        {
            if (string.IsNullOrEmpty(txtNomeFuncionario.Text))
            {
                MessageBox.Show("O campo do nome precisa ser preenchido", "Aviso");
            }
            else if (string.IsNullOrEmpty(txtCpfFuncionario.Text))
            {
                MessageBox.Show("O campo do CPF precisa ser preenchido", "Aviso");
            }
            else if (string.IsNullOrEmpty(txtTelefoneFuncionario.Text))
            {
                MessageBox.Show("O campo do telefone precisa ser preenchido", "Aviso");
            }
            else if (string.IsNullOrEmpty(txtEmailFuncionario.Text))
            {
                MessageBox.Show("O campo do email precisa ser preenchido", "Aviso");
            }
            else if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("O campo do usuário precisa ser preenchido", "Aviso");
            }
            else if (string.IsNullOrEmpty(txtSenhaFunc.Text))
            {
                MessageBox.Show("O campo da senha precisa ser preenchido", "Aviso");
            }
            else if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cargo");
            }


            else
            {
                funcDTO.FuncNome = txtNomeFuncionario.Text;
                funcDTO.FuncCPF = txtCpfFuncionario.Text;
                funcDTO.FuncTelefone = txtTelefoneFuncionario.Text;
                funcDTO.FuncEmail = txtEmailFuncionario.Text;
                funcDTO.FuncDeficiente = cmbDef.SelectedItem.ToString();
                funcDTO.Usuario = txtUser.Text;
                funcDTO.Senha = txtSenhaFunc.Text;

                if (cmbCargo.SelectedItem.ToString() == "Admin")
                {
                    funcBLL.InserirFuncionario(funcDTO, 1);
                }
                else if (cmbCargo.SelectedItem.ToString() == "Operador")
                {
                    funcBLL.InserirFuncionario(funcDTO, 2);
                }
                else if (cmbCargo.SelectedItem.ToString() == "Técnico")
                {
                    funcBLL.InserirFuncionario(funcDTO, 3);
                }
                MessageBox.Show("O funcionario foi cadastrado com sucesso", "Inserido com sucesso", MessageBoxButtons.OK);
            }

            CarregarGridFuncionarios();
        }
        private void CarregarGridFuncionarios()
        {
            gridFuncionarios.DataSource = funcBLL.SelecionarTodosFuncionarios();
        }
        
        private void btnAlterarFuncionario_Click(object sender, EventArgs e) //botão alterar
        {
            funcDTO.FuncID = txtIdFuncionario.Text;
            funcDTO.FuncNome = txtNomeFuncionario.Text;
            funcDTO.FuncCPF = txtCpfFuncionario.Text;
            funcDTO.FuncTelefone = txtTelefoneFuncionario.Text;
            funcDTO.FuncEmail = txtEmailFuncionario.Text;
            funcDTO.FuncDeficiente = cmbDef.SelectedItem.ToString();
            funcDTO.Usuario = txtUser.Text;
            funcDTO.Senha = txtSenhaFunc.Text;

            var result = MessageBox.Show("Deseja realmente atualizar o funcionario?", "Atualização Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                if (cmbCargo.SelectedItem.ToString() == "Admin")
                {
                    
                    funcBLL.AtualizarFuncionario(funcDTO, 1);
                }
                else if (cmbCargo.SelectedItem.ToString() == "Operador")
                {
                    
                    funcBLL.AtualizarFuncionario(funcDTO, 2);

                }
                else if (cmbCargo.SelectedItem.ToString() == "Técnico")
                {
                    funcBLL.AtualizarFuncionario(funcDTO, 3);
                }
                MessageBox.Show("O funcionario foi atualizado com sucesso", "Atualização com sucesso", MessageBoxButtons.OK);
                LimparTela();
                CarregarGridFuncionarios();
            }
        }

        private void btnLimparFuncionario_Click(object sender, EventArgs e)//botão limpar
        {
            LimparTela();
            btnSalvarFuncionario.Enabled = true;
        }

        private void LimparTela()
        {
            txtIdFuncionario.Clear();
            txtNomeFuncionario.Clear();
            txtCpfFuncionario.Clear();
            txtEmailFuncionario.Clear();
            txtTelefoneFuncionario.Clear();
            txtUser.Clear();
            txtSenhaFunc.Clear();
            txtSituacao.Clear();
            cmbCargo.SelectedIndex = -1;//seleciona o primeiro indice vazio
            cmbDef.SelectedIndex = 1;
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)//botão excluir
        {
            funcDTO.FuncID = txtIdFuncionario.Text;
            funcDTO.FuncCPF = txtCpfFuncionario.Text;
            funcDTO.FuncSituacao = txtSituacao.Text;
            var result = MessageBox.Show("Deseja realmente desabilitar o funcionario?", "Exclusão Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                funcBLL.ExcluirFuncionario(funcDTO.FuncCPF);
                LimparTela();
                CarregarGridFuncionarios();
            }
        }

        private void gridFuncionarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeFuncionario.Text = gridFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCpfFuncionario.Text = gridFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefoneFuncionario.Text = gridFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmailFuncionario.Text = gridFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbDef.Text = gridFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSituacao.Text = gridFuncionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbCargo.Text = gridFuncionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtUser.Text = gridFuncionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtSenhaFunc.Text = gridFuncionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
            btnSalvarFuncionario.Enabled = false;
        }

        private void txtTelefoneFuncionario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void txtNomeFuncionario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarGridFuncionarios();
            cmbDef.SelectedIndex = 1;
            this.gridFuncionarios.Columns[4].Visible = false;//esconde a coluna do gridview
            this.gridFuncionarios.Columns[8].Visible = false;
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            funcDTO.FuncID = txtIdFuncionario.Text;
            funcDTO.FuncCPF = txtCpfFuncionario.Text;
            funcDTO.FuncSituacao = txtSituacao.Text;
            var result = MessageBox.Show("Deseja realmente habilitar o funcionario?", "Exclusão Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                funcBLL.AtivarFuncionario(funcDTO.FuncCPF);
                LimparTela();
                CarregarGridFuncionarios();
            }
        }

        private void cmbCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDef_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
