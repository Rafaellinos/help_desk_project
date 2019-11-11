using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using PIM4SEMVER1._0.DTO;
using System.Configuration;

namespace PIM4SEMVER1._0.DAL
{
    class AcessoMySQLDAO
    {
        
        private MySqlConnection objcon;
        private DataTable data;
        //private MySqlDataAdapter da;
        private MySqlDataReader dr;
        CadastroClienteDTO dto = new CadastroClienteDTO();
        ChamadosDTO dtochamado = new ChamadosDTO();
        TelaPrincipalDTO telaPrinDto;
        
        public void Conectar()
        {
            if (objcon != null) // se o objeto de conexão diferente de nullo
                objcon.Close();


            string connStr = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
                //String.Format("Server=localhost;Database=banco_pim;Uid=root;Pwd=PWD;");
            try
            {
                objcon = new MySqlConnection(connStr);
                objcon.Open();
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao inserir dados" + erro.Message);
            }
        }

        public void ExecutarComandoSQL(string comandoSql) //espera um comando, como delete, update etc
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.ExecuteNonQuery();
            objcon.Close();
        }

        public CadastroClienteDTO ExecutaEretornaReader(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();
            //enquanto tiver linhas para serem lidas
            while (dr.Read())
            {
                dto.ClienteNome = dr.GetString(0);
                dto.ClienteFixo1 = dr.GetString(1);
                dto.ClienteCel1 = dr.GetString(2);
                dto.ClienteEmail = dr.GetString(3);
                dto.ClienteLogradouro = dr.GetString(4);
                dto.ClienteNcasa = dr.GetString(5);
                dto.ClienteComplemento = dr.GetString(6);
                dto.ClienteBairro = dr.GetString(7);
                dto.ClienteCidade = dr.GetString(8);
                dto.ClienteUF = dr.GetString(9);
                dto.ClienteCEP = dr.GetString(10);
                dto.ClienteCPF = dr.GetString(11);
                dto.ClienteId = dr.GetInt32(12);
                dto.ClienteSituacao = dr.GetString(13);
            }
            //fechando o leitor
            dr.Close();
            //retornando a Collection com os dados
            return dto;

        }

        //Verifica se existe, é usado para verificar login e se existe cpf/cnpj
        public bool VerificaRetornaBool(string comandoSql)
        {
            bool result = false;

            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            MySqlDataReader dados = comando.ExecuteReader();
            result = dados.HasRows;

            return result;
        }
        
        //Retorna uma lista de string qualquer, dependendo do comando
        public List<string> ExecutaRetornaListaStrings(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();
            List<string> ListaGenerica = new List<string>();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    ListaGenerica.Add(dr.GetString(0));
                }
                dr.Close();
            }
            return ListaGenerica;
        }

        private MySqlDataAdapter da;
        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, objcon);
            da.Fill(data);
            return data;
        }

        
        public List<int> RetornaListaIds(string comandoSql) //retorna uma lista de Ids caso necessário
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();
            List<int> Ids = new List<int>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Ids.Add(dr.GetInt32(0));
                }
                dr.Close();
            }
            return Ids;
        }
        
        public List<TelaPrincipalDTO> RetornaUltimosChamados (string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();

            List<TelaPrincipalDTO> telaPrinDtos = new List<TelaPrincipalDTO>();
            //enquanto tiver linhas para serem lidas
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    telaPrinDto = new TelaPrincipalDTO();

                    telaPrinDto.TelaPrincResumo1 = dr.GetString(0);
                    telaPrinDto.TelaPrincData1 = dr.GetMySqlDateTime(1).ToString();
                    telaPrinDto.TelaPrincProto1 = dr.GetInt32(2).ToString();
                    telaPrinDtos.Add(telaPrinDto);

                }
            }
            return telaPrinDtos;
        }

        public ChamadosDTO ExecutaRetornaCliente(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();
            //enquanto tiver linhas para serem lidas
            while (dr.Read())
            {
                dtochamado.ChamadoNomeCliente = dr.GetString(0);
                dtochamado.ChamadoRuaCliente = dr.GetString(1);
                dtochamado.ChamadoNumeroRuaCliente = dr.GetString(2);
                dtochamado.ChamadoIdCliente = dr.GetInt32(3);
                dtochamado.ChamadoSituaCliente = dr.GetString(4);
            }
            //fechando o leitor
            dr.Close();
            //retornando a Collection com os dados
            return dtochamado;
        }

        //retorna um ID (int qualquer)
        public int RetornaIDusuario(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();
            int ID = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ID = dr.GetInt32(0);
                }
                dr.Close();
            }
            return ID;
        }

        //retorna uma string qualquer
        public string RetornaNomeFuncionario(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();
            string nomeFuncio = "";

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nomeFuncio = dr.GetString(0);
                }
                dr.Close();
            }
            return nomeFuncio;
        }

        public ChamadosDTO BuscarChamadoPeloProtocolo(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, objcon);
            comando.CommandType = CommandType.Text;
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                dtochamado.ChamadoProtocolo = dr.GetInt32(0);
                dtochamado.ChamadoNomeCliente = dr.GetString(1);
                
                dtochamado.ChamadoData = dr.GetMySqlDateTime(2).ToString();
                dtochamado.ChamadaHora = dr.GetString(3);
                dtochamado.ChamadoModelo = dr.GetString(4);
                dtochamado.ChamadoResumo = dr.GetString(5);
                dtochamado.ChamadoNomeFunc = dr.GetString(6);
                dtochamado.ChamadoDescricao = dr.GetString(7);
                dtochamado.ChamadoCPF = dr.GetString(8);//cpf ou cpnj
                dtochamado.ChamadoSituacao = dr.GetString(9);
                dtochamado.ChamadoLocal = dr.GetString(10);
                dtochamado.ChamadoVisita = dr.GetString(11);
                dtochamado.ChamadoSituaCliente = dr.GetString(12);
            }
            dr.Close();

            return dtochamado;
        }

    }
}
