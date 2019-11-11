using System.Collections.Generic;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.DAL
{
    class TelaPrincipalDAO
    {
        AcessoMySQLDAO bd = new AcessoMySQLDAO();
        TelaPrincipalDTO telaprincDto = new TelaPrincipalDTO();
        

        public List<string> ExecuraRetornaReade()
        {
            bd.Conectar();
            List<string> Lista = new List<string>();



            string comando = "select situacao from chamado";
            Lista = bd.ExecutaRetornaListaStrings(comando);


            return Lista;

        }
        
        public string RetornaDadosLogin(string usu)
        {
            bd.Conectar();
            string nivelAcesso;

            string comando = "select nivelAcesso from login where usuario = '" + usu + "';";
            nivelAcesso = bd.RetornaNomeFuncionario(comando);

            return nivelAcesso;
        }
        
        public List<int> RetornaIDs()
        {
            List<int> IDs = new List<int>();

            bd.Conectar();

            string comando = "select protocolo from chamado where situacao = 'Aberto'";
            IDs = bd.RetornaListaIds(comando);

            return IDs;
        }
        //retornar assunto, data, hora e numero chamado
        public List<TelaPrincipalDTO> RetornaUltimosChamados()
        {

            bd.Conectar();
            List<TelaPrincipalDTO> principalDTO = new List<TelaPrincipalDTO>();
           
            string comando = "select assunto, dataChamado, protocolo from chamado where situacao = 'Aberto' order by dataChamado,horaChamado asc limit 3;";
            //procura os chamados abertos mais antigos
            principalDTO = bd.RetornaUltimosChamados(comando);

            return principalDTO;
        }

        public ChamadosDTO CarregaUltimoChamado (int protocolo)
        //métoco responsável por carregar o último chamado para tela de alterar chamado
        {
            ChamadosDTO chamadosDTO = new ChamadosDTO();
            int idCliente = 0;
            string CPF;

            bd.Conectar();
            string comando = "select cliente_idCliente from chamado where protocolo = '" + protocolo + "'";
            idCliente = bd.RetornaIDusuario(comando);

            bd.Conectar();
            string comando1 = "select cpf from pessoafisica where cliente_idCliente = '"+idCliente+"'";
            CPF = bd.RetornaNomeFuncionario(comando1);

            if(CPF.Length == 11)
            {
                bd.Conectar();
                string comando2 = "select c.protocolo, c.nomeCliente, c.dataChamado, c.horaChamado, e.modelo , c.assunto, c.nomeFuncionario, c.descricao, p.cpf, " +
                    "c.situacao, c.local, c.visitaTenica, a.statusCli from chamado c join " +
                        "equipamentochamado ec on c.protocolo = ec.chamado_protocolo join equipamento e on ec.equipamento_idEquipamento = e.idEquipamento " +
                        "join pessoafisica p on p.cliente_idCliente = c.cliente_idCliente join cliente a on p.cliente_idCliente = a.idCliente where protocolo = '" + protocolo + "';";
                chamadosDTO = bd.BuscarChamadoPeloProtocolo(comando2);
            }
            else
            {
                bd.Conectar();
                string comando2 = "select c.protocolo, c.nomeCliente, c.dataChamado, c.horaChamado, e.modelo , c.assunto, c.nomeFuncionario, c.descricao, p.cnpj, " +
                    "c.situacao, c.local, c.visitaTenica, a.statusCli from chamado c join " +
                        "equipamentochamado ec on c.protocolo = ec.chamado_protocolo join equipamento e on ec.equipamento_idEquipamento = e.idEquipamento " +
                        "join pessoajuridica p on p.cliente_idCliente = c.cliente_idCliente join cliente a on p.cliente_idCliente = a.idCliente where protocolo = '" + protocolo + "';";
                chamadosDTO = bd.BuscarChamadoPeloProtocolo(comando2);
            }

            

            return chamadosDTO;
        }
    }
}