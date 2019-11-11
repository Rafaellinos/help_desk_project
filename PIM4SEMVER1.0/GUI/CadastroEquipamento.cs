using System;
using System.Windows.Forms;
using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.BLL;

namespace PIM4SEMVER1._0.GUI
{
    public partial class CadastroEquipamento : Form
    {

        CadastroEquipamentoBLL CadastroEquipBLL = new CadastroEquipamentoBLL();
        CadastroEquipamentoDTO EquipDTO = new CadastroEquipamentoDTO();

        public CadastroEquipamento()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;



            cbCategoria.Items.Add("Desktop");
            cbCategoria.Items.Add("Notebook");
            cbCategoria.Items.Add("Periféricos");

            
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem.ToString() == "Desktop")
            {
                
                dgvModelos.DataSource = CadastroEquipBLL.fillComboEquipamentos(1);
            }
            else if(cbCategoria.SelectedItem.ToString()== "Notebook")
            {
                dgvModelos.DataSource = CadastroEquipBLL.fillComboEquipamentos(2);
            }
            else if(cbCategoria.SelectedItem.ToString()== "Periféricos")
            {
                dgvModelos.DataSource = CadastroEquipBLL.fillComboEquipamentos(3);
            }
            else
            {
                MessageBox.Show("Selecione uma categoria","Aviso!");
            }
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria para adicionar um novo modelo", "Aviso!");
            }
            else if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Digite um modelo válido","Aviso!");
            }
            else
            {
                int marca = 1;//sistema possui apenas uma marca

                if (cbCategoria.SelectedIndex == 0)
                {
                    EquipDTO.EquipNome = txtModelo.Text;
                    EquipDTO.EquipStatus = "ativado";

                    CadastroEquipBLL.Inserir(EquipDTO, marca, 1);
                    MessageBox.Show("Equipamento adicionado com sucesso!");
                    limpar();
                }
                else if(cbCategoria.SelectedIndex == 1)
                {
                    EquipDTO.EquipNome = txtModelo.Text;
                    EquipDTO.EquipStatus = "ativado";

                    CadastroEquipBLL.Inserir(EquipDTO, marca, 2);
                    MessageBox.Show("Equipamento adicionado com sucesso!");
                    limpar();
                }
                else if(cbCategoria.SelectedIndex == 2)
                {
                    EquipDTO.EquipNome = txtModelo.Text;
                    EquipDTO.EquipStatus = "ativado";

                    CadastroEquipBLL.Inserir(EquipDTO, marca, 3);
                    MessageBox.Show("Equipamento adicionado com sucesso!");
                    limpar();
                }


            }
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (dgvModelos.RowCount == 0)
            {
                MessageBox.Show("Selecione uma categoria e em seguida o campo do equipamento que deseja ativar","Aviso!");
            }
            else if(cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria e em seguida o campo do equipamento que deseja ativar", "Aviso!");
            }
            else
            {
                int indiceAtual = 0;
                indiceAtual = dgvModelos.CurrentRow.Index;

                EquipDTO.EquipNome = dgvModelos.Rows[indiceAtual].Cells[0].Value.ToString();

                if (dgvModelos.Rows[indiceAtual].Cells[1].Value.ToString() == "ativo")
                {
                    MessageBox.Show("Esse equipamento já está ativo", "Aviso!");
                }
                else
                {
                    
                    CadastroEquipBLL.Ativar(EquipDTO);
                    MessageBox.Show("Equipamento ativado com sucesso!","Aviso!");
                    limpar();
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (dgvModelos.RowCount == 0)
            {
                MessageBox.Show("Selecione uma categoria e em seguida o campo do equipamento que deseja desativar", "Aviso!");
            }
            else if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria e em seguida o campo do equipamento que deseja desativar", "Aviso!");
            }
            else
            {
                int indiceAtual = 0;
                indiceAtual = dgvModelos.CurrentRow.Index;

                EquipDTO.EquipNome = dgvModelos.Rows[indiceAtual].Cells[0].Value.ToString();
                
                if (dgvModelos.Rows[indiceAtual].Cells[1].Value.ToString() == "desativado")
                {
                    MessageBox.Show("Esse equipamento já está desativado", "Aviso!");
                }
                else
                {
                    
                    CadastroEquipBLL.Desativar(EquipDTO);
                    MessageBox.Show("Equipamento desativado com sucesso!","Aviso!");
                    limpar();
                }
            }
        }
        private void limpar()
        {
            cbCategoria.Text = "";
            txtModelo.Clear();
            dgvModelos.Columns.Clear();
        }
        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
