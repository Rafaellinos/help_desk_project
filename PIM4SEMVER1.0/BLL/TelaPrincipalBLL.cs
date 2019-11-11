using PIM4SEMVER1._0.DAL;
using System.Collections.Generic;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.BLL
{
    class TelaPrincipalBLL
    {

        TelaPrincipalDAO cb = new TelaPrincipalDAO();
        TelaPrincipalDTO telaprincDto = new TelaPrincipalDTO();

        
        public List<string> ExecutaLedadosBD()
        //busca uma lista com todos os chamados abertos e fechados para contagem e inserção no gráfico
        {
            List<string> lista = new List<string>();
            lista = cb.ExecuraRetornaReade();
            

            return lista;
        }
        
        public string ExecutaRetornaLogin(string usu)
        //retorna o nível de acesso do usuário atual
        {
            
            string nivelAcesso;

            nivelAcesso = cb.RetornaDadosLogin(usu);

            return nivelAcesso;
        }
        
        public List<int> ExecutaRetornaIds()
        {
            List<int> Ids = new List<int>();
            Ids = cb.RetornaIDs();

            return Ids;
        }

        public List<TelaPrincipalDTO> RetornaUltimosChamados()
        {
            //List<string> UltimosChamados = new List<string>();
            List<TelaPrincipalDTO> telaprincDto = new List<TelaPrincipalDTO>();
            telaprincDto = cb.RetornaUltimosChamados();

            return telaprincDto;


        }
        public ChamadosDTO CarregaUltimoChamado(int protocolo)
        {
            ChamadosDTO chamadoDto = new ChamadosDTO();
            chamadoDto = cb.CarregaUltimoChamado(protocolo);
            return chamadoDto;
        }


    }
}