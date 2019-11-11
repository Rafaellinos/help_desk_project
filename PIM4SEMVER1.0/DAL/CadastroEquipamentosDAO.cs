using System.Data;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.DAL
{
    class CadastroEquipamentosDAO
    {
        
        AcessoMySQLDAO bd = new AcessoMySQLDAO();
        CadastroEquipamentoDTO EquipDto = new CadastroEquipamentoDTO();


        public DataTable fillComboEquipamentos(int categoria) 
            //retorna todas as marcas do bd, o parâmetro int determina sua categoria, sendo 1=periféricos, 2= desktop, 3=equipamento
        {

            bd.Conectar();
            DataTable dtos = new DataTable();
            
            string cmdModelo = "select modelo, statusEquip from equipamento where categoria_idcategoria = '"+categoria+"'";
            dtos = bd.RetDataTable(cmdModelo);


            return dtos;
        }

        public void Inserir(CadastroEquipamentoDTO EquipDto, int marca, int idcategoria)
        {
            bd.Conectar();
            string comando = "insert into equipamento (modelo, statusEquip, marca_idMarca,categoria_idcategoria) values " +
                " ('"+EquipDto.EquipNome+"','"+EquipDto.EquipStatus+"','"+marca+"','"+idcategoria+"');";
            bd.ExecutarComandoSQL(comando);
        }
        public void Ativar(CadastroEquipamentoDTO EquipDto)
        {
            bd.Conectar();
            string comando = "update equipamento set statusEquip = 'ativado' where modelo = '" + EquipDto.EquipNome + "'";
            bd.ExecutarComandoSQL(comando);
        }
        public void Desativar(CadastroEquipamentoDTO EquipDto)
        {
            bd.Conectar();
            string comando = "update equipamento set statusEquip = 'desativado' where modelo = '" + EquipDto.EquipNome + "'";
            bd.ExecutarComandoSQL(comando);
        }
    }
}
