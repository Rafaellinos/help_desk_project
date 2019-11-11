using System;
using System.Collections.Generic;
using System.Data;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.DAL
{
    class ChamadoDAO
    {
        AcessoMySQLDAO bd = new AcessoMySQLDAO();

        public ChamadosDTO BuscarCliente(string dto)
        {
            bd.Conectar();
            ChamadosDTO chamadosDTO = new ChamadosDTO();

            if (dto.Length == 11)
            {
                string comando = "select c.nome,a.rua, a.numero, c.idCliente, c.statusCli from cliente c join endereco a on c.idCliente = a.cliente_idCliente " +
                    "join pessoafisica p on c.idCliente = p.cliente_idCliente where cpf = '" + dto + "';";
                chamadosDTO = bd.ExecutaRetornaCliente(comando);
            }
            else if (dto.Length == 14)
            {
                string comando = "select c.nome,a.rua, a.numero, c.idCliente, c.statusCli from cliente c join endereco a on c.idCliente = a.cliente_idCliente " +
                    "join pessoajuridica p on c.idCliente = p.cliente_idCliente where cnpj = '" + dto + "';";
                chamadosDTO = bd.ExecutaRetornaCliente(comando);
            }

            return chamadosDTO;
        }

        public List<string> fillCombo(int categoria) //retorna todas as marcas do bd, o parâmetro int determina sua categoria, sendo 1=periféricos, 2= desktop, 3=equipamento
        {
            bd.Conectar();
            List<string> dtos = new List<string>();
            
            
           
            string cmdModelo = "select modelo from equipamento where categoria_idcategoria = " + categoria + "";
            //seleciona o modelo do equipamento apartir de uma categoria 

            dtos = bd.ExecutaRetornaListaStrings(cmdModelo);


            return dtos;
        }

        public int Inserir(ChamadosDTO dto)
        {
            int protocolo = 0;
            try
            {
                List<int> Lista = new List<int>();
                
                int Lista1;

                bd.Conectar();
                string comando = "Select idEquipamento from equipamento where modelo ='" + dto.ChamadoNomeEqui + "'; ";
                Lista = bd.RetornaListaIds(comando); //Retorna o idEquipamento
                dto.ChamadoIDEquipam = Lista[0];
                

                bd.Conectar();
                string comando1 = "Insert into chamado(nomeCliente, nomeFuncionario, dataChamado, horaChamado, descricao, situacao, funcnionario_idFuncionario, " +
                    "cliente_idCliente, assunto, local,visitaTenica) values ('" + dto.ChamadoNomeCliente + "', '" + dto.ChamadoNomeFunc + "','" + dto.ChamadoData + "','" + dto.ChamadaHora + "','" + dto.ChamadoDescricao + "'," +
                    " '" + dto.ChamadoSituacao + "'," + dto.ChamadoIDfunci + ",'" + dto.ChamadoIdCliente + "','" + dto.ChamadoResumo + "','"+dto.ChamadoLocal+"','"+dto.ChamadoVisita+"');"; //insere as info de chamado vindo da GUI
                bd.ExecutarComandoSQL(comando1); //executa o comando na classe AcessoMySql e fecha conexão


                bd.Conectar();
                string comando3 = "select protocolo from chamado where protocolo = LAST_INSERT_ID();";
                Lista1 = bd.RetornaIDusuario(comando3);
                protocolo = Lista1;

                
                bd.Conectar();
                string comando2 = "Insert into equipamentochamado(chamado_protocolo, equipamento_idEquipamento) values ("+Lista1+",'" + dto.ChamadoIDEquipam + "');"; //insere o protocolo(id do chamado) e o idquipamento

                bd.ExecutarComandoSQL(comando2);
                

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Test"+e);
            }

            return protocolo;
        }



        public DataTable BuscarChamado(ChamadosDTO dto)
        {
            bd.Conectar();
            ChamadosDTO chamadosDTO = new ChamadosDTO();

            DataTable Dtchamado = new DataTable();

            if (dto.ChamadoCPF.Length == 11)
            {
                string comando = "select c.protocolo, c.nomeCliente, c.dataChamado, c.horaChamado, e.modelo , c.assunto, c.nomeFuncionario, c.descricao, " +
                    "p.cpf, c.situacao, c.local, c.visitaTenica from chamado c join equipamentochamado ec on c.protocolo = ec.chamado_protocolo join equipamento e " +
                    "on ec.equipamento_idEquipamento = e.idEquipamento join pessoafisica p on p.cliente_idCliente = c.cliente_idCliente where cpf = '" + dto.ChamadoCPF + "';";
                Dtchamado = bd.RetDataTable(comando);

            }
            else if (dto.ChamadoCNPJ.Length == 14)
            {
                string comando = "select c.protocolo, c.nomeCliente, c.dataChamado, c.horaChamado, e.modelo , c.assunto, c.nomeFuncionario, c.descricao, p.cnpj, c.situacao, c.local, c.visitaTenica from chamado c join " +
                    " equipamentochamado ec on c.protocolo = ec.chamado_protocolo join equipamento e on ec.equipamento_idEquipamento = e.idEquipamento" +
                    " join pessoajuridica p on p.cliente_idCliente = c.cliente_idCliente where cnpj = '" + dto.ChamadoCNPJ + "';";
                Dtchamado = bd.RetDataTable(comando);

            }

            return Dtchamado;
        }

        public void AlterarChamado(ChamadosDTO dtochamado)
        {
            bd.Conectar();
            ChamadosDTO chamadosDTO = new ChamadosDTO();
            if (dtochamado.ChamadoCPF.Length == 11)
            {
                string comando = "Update chamado set descricao='" + dtochamado.ChamadoDescricao + "', assunto='" + dtochamado.ChamadoResumo + "', situacao = '" + dtochamado.ChamadoSituacao + "' " +
                    " , dataChamado='" + dtochamado.ChamadoData + "', horaChamado='" + dtochamado.ChamadaHora + "', nomeFuncionario='" + dtochamado.ChamadoNomeFunc +"' " +
                    " , funcnionario_idFuncionario="+dtochamado.ChamadoIDfunci+", local='"+dtochamado.ChamadoLocal+"'  where protocolo = " + dtochamado.ChamadoProtocolo + ";";
                bd.ExecutarComandoSQL(comando);
            }
            else if (dtochamado.ChamadoCNPJ.Length == 14)
            {
                string comando = "Update chamado set descricao='" + dtochamado.ChamadoDescricao + "', assunto='" + dtochamado.ChamadoResumo + "', situacao = '" + dtochamado.ChamadoSituacao + "'" +
                    ", dataChamado='" + dtochamado.ChamadoData + "', horaChamado='" + dtochamado.ChamadaHora + "'" +
                    " , nomeFuncionario='" + dtochamado.ChamadoNomeFunc + "' " +
                    " , funcnionario_idFuncionario=" + dtochamado.ChamadoIDfunci + ", local='" + dtochamado.ChamadoLocal + "' where protocolo = " + dtochamado.ChamadoProtocolo + " ;";
                bd.ExecutarComandoSQL(comando);
            }



        }
        public int RetornaIDusuario(string usu)
        {
            bd.Conectar();
            int ID = 0;
            string comando = "select funcnionario_idFuncionario from login where usuario = '" + usu + "';";
            ID = bd.RetornaIDusuario(comando);

            return ID;

        }
        public string RetornaNomeFuncio(string usu)
        {
            bd.Conectar();
            string nomefuncio;
            string comando = "select f.nome from funcnionario f join login l on f.idFuncionario = l.funcnionario_idFuncionario where usuario = '" + usu + "';";
            nomefuncio = bd.RetornaNomeFuncionario(comando);
            return nomefuncio;
        }
    }
}
