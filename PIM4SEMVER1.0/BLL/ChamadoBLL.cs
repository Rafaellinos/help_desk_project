using System.Collections.Generic;
using System.Data;
using PIM4SEMVER1._0.DAL;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.BLL
{
    class ChamadoBLL
    {
        ChamadoDAO DAL = new ChamadoDAO();
        ChamadosDTO chamadoDto;

        //busca o cliente para relacionar com um chamado
        public ChamadosDTO BuscarCliente (string dto)
        {
            chamadoDto = new ChamadosDTO();

            chamadoDto = DAL.BuscarCliente(dto);
            return chamadoDto;
        }

        //preenche o combobox de marcas apartir da categoria selecionada
        public List<string> fillCombo(int categoria)
        {
            List<string> ListaModelos = new List<string>();
            ListaModelos = DAL.fillCombo(categoria);
            return ListaModelos;
        }

        //envia comando para inserir um chamado
        public int Inserir(ChamadosDTO chamadosDTO)
        {
            int protocolo = 0;
            protocolo = DAL.Inserir(chamadosDTO);
            return protocolo;
        }

        //retorna uma datatable com todos os chamados do cliente pesquisado
        public DataTable BuscarChamado(ChamadosDTO chamadosDTO)
        {
            DataTable DadosChamado = new DataTable();
            DadosChamado = DAL.BuscarChamado(chamadosDTO);
            return DadosChamado;
        }

        //envia comando para alterar o chamado
        public void AlterarChamado(ChamadosDTO chamadosDTO)
        {
            DAL.AlterarChamado(chamadosDTO);
        }



        //Retorna ID do usuário para abrir o chamado e relacionar com um Funcionario
        public int IDusuario(string usu)
        {
            int ID = 0;
            ID =DAL.RetornaIDusuario(usu);
            return ID;
        }

        //Retorna o nome do funcionario para colocar na abertura do chamado
        public string NomeFuncionario(string usu)
        {
            string nomeFunc;
            nomeFunc = DAL.RetornaNomeFuncio(usu);
            return nomeFunc;
        }



    }
}