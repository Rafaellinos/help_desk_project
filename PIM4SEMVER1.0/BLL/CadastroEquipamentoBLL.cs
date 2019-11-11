using System.Data;
using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.DAL;

namespace PIM4SEMVER1._0.BLL
{
    class CadastroEquipamentoBLL
    {
        CadastroEquipamentosDAO CadastroEquip = new CadastroEquipamentosDAO();

        public DataTable fillComboEquipamentos(int categoria)
        {
            DataTable modelos = new DataTable();
            modelos = CadastroEquip.fillComboEquipamentos(categoria);
            return modelos;
        }
        public void Inserir(CadastroEquipamentoDTO EquipDto, int marca, int idcategoria)
        {
            CadastroEquip.Inserir(EquipDto, marca, idcategoria);
        }
        public void Ativar(CadastroEquipamentoDTO EquipDto)
        {
            CadastroEquip.Ativar(EquipDto);
        }
        public void Desativar(CadastroEquipamentoDTO EquipDto)
        {
            CadastroEquip.Desativar(EquipDto);
        }
    }
}
