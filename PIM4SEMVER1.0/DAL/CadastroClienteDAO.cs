using System;
using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.DAL;


namespace PIM4SEMVER1._0.BLL
{
    class CadastroClienteDAO
    {

        AcessoMySQLDAO bd = new AcessoMySQLDAO();
        CadastroClienteDTO dtos;
       
        public void Inserir(CadastroClienteDTO dto) 
        //recebe o objeto cliente preenchido da camada GUI
        {
            try
            {
                string nome = dto.ClienteNome.Replace("'", "''");

                
                bd.Conectar();
                //insere dados do cliente
                string comando = "INSERT INTO cliente(idCliente, nome, telefoneFix, telefoneCel, email, statusCli) VALUES" +
                    " (null,'" + nome + "','" + dto.ClienteFixo1 + "','"+dto.ClienteCel1+"','" + dto.ClienteEmail + "', 'ativado')";
                bd.ExecutarComandoSQL(comando);
                //verifica se é cpf ou cnpj que será inserido
                if (dto.ClienteEscolha == "CPF")
                {
                    
                    bd.Conectar();
                    string comando1 = "INSERT INTO pessoafisica(cpf, cliente_idCliente) VALUES " +
                        "('" + dto.ClienteCPF + "',LAST_INSERT_ID())";
                    bd.ExecutarComandoSQL(comando1);

                }
                else if (dto.ClienteEscolha == "CNPJ")
                {
                    
                    bd.Conectar();
                    string comando1 = "INSERT INTO pessoajuridica(cnpj, cliente_idCliente) VALUES ('" + dto.ClienteCNPJ + "',LAST_INSERT_ID())";
                    bd.ExecutarComandoSQL(comando1);
                }
                //insere endereço do cliente
                bd.Conectar();
                string comando2 = "INSERT INTO endereco(rua, numero, complemento, bairro, cidade, uf, cep, cliente_idCliente)VALUES " +
                    "('" + dto.ClienteLogradouro + "','" + dto.ClienteNcasa + "','" + dto.ClienteComplemento + "','" + dto.ClienteBairro + "'" +
                    ",'" + dto.ClienteCidade + "','" + dto.ClienteUF + "','" + dto.ClienteCEP + "',LAST_INSERT_ID())";
                bd.ExecutarComandoSQL(comando2); 
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao tentar atualizar o cliente" + erro.Message);
            }
           
        }



        public CadastroClienteDTO Buscar(string dto, string escolha)
            //recebe a string escolha para verificar se é cpf ou cnpj
            //recebe a string dto para buscar os dados do cliente apartir do CPF ou CNPJ
        {
            
            bd.Conectar();
            dtos = new CadastroClienteDTO();
            if (escolha == "CPF")
            {
                string comando = "select c.nome, c.telefoneFix, telefoneCel, c.email, a.rua, a.numero, a.complemento, a.bairro, a.cidade," +
                    " a.uf, a.cep, p.cpf, c.idCliente, c.statusCli from cliente c join endereco a on" +
                    " c.idCliente = a.cliente_idCliente join pessoafisica p on c.idCliente = p.cliente_idCliente " +
                    "where cpf = '" + dto + "';";
                dtos = bd.ExecutaEretornaReader(comando);
            }
            else if(escolha == "CNPJ")
            {
                string comando = "select c.nome, c.telefoneFix,c.telefoneCel, c.email, a.rua, a.numero, a.complemento, a.bairro, a.cidade, a.uf, a.cep," +
                    " p.cnpj, c.idCliente, c.statusCli from cliente c join endereco a on c.idCliente = a.cliente_idCliente join pessoajuridica p " +
                    " on c.idCliente = p.cliente_idCliente where cnpj = '" + dto + "';";
                dtos = bd.ExecutaEretornaReader(comando);
            }
            return dtos; //retorna os dados para preencher na cama GUI
        }

      
        public void Atualizar(CadastroClienteDTO dto)
        {
            //recebe o objeto cliente preenchido para atualizar apartir do id do cliente
            try
            {
                bd.Conectar();

                string comando = "UPDATE cliente set nome='" + dto.ClienteNome + "',telefoneFix='" + dto.ClienteFixo1 + "',telefoneCel='"+dto.ClienteCel1+"', " +
                    "email='" + dto.ClienteEmail + "' " +
                    "where idCliente = '"+dto.ClienteId+ "'";
                bd.ExecutarComandoSQL(comando);
                bd.Conectar();
                string comando1 = "UPDATE endereco set rua='" + dto.ClienteLogradouro + "', numero='" + dto.ClienteNcasa + "', complemento='" + dto.ClienteComplemento + "', " +
                    "bairro='" + dto.ClienteBairro + "', cidade='" + dto.ClienteCidade + "', uf='" + dto.ClienteUF + "', cep='" + dto.ClienteCEP + "' " +
                    "where cliente_idCliente = '" + dto.ClienteId + "'";
                bd.ExecutarComandoSQL(comando1);
                if(dto.ClienteCPF.Length == 11)
                {
                    bd.Conectar();
                    string comando2 = "update pessoafisica set cpf='"+dto.ClienteCPF+"' where cliente_idCliente='"+dto.ClienteId+"'";
                    bd.ExecutarComandoSQL(comando2);
                }
                else if(dto.ClienteCNPJ.Length == 14)
                {
                    bd.Conectar();
                    string comando2 = "update pessoajuridica set cnpj='" + dto.ClienteCNPJ + "' where cliente_idCliente='" + dto.ClienteId + "'";
                    bd.ExecutarComandoSQL(comando2);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao tentar Cadastrar o cliente" + erro.Message);
            }
        }


        public void Excluir(CadastroClienteDTO dto)
        {
            //Desativa o cliente
            try
            {
                bd.Conectar();
                string comando = "UPDATE cliente set statusCli='desativado' where idCliente = '" + dto.ClienteId + "'";
                bd.ExecutarComandoSQL(comando);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o funcionario: " + ex.Message);
            }
        }

        public bool CPFeCNPJExiste(string cpfoucnpj)
        {
            //verifica se o cliente existe apartir do CPF ou CNPJ para não inserir 2 cpfs/cnpjs iguais
            bool existe = false;
            try
            {
                
                bd.Conectar();
                if(cpfoucnpj.Length == 11)
                {
                    string comando = "select CPF from pessoafisica where CPF = '" + cpfoucnpj + "';";
                    existe = bd.VerificaRetornaBool(comando);
                }
                else if(cpfoucnpj.Length == 14)
                {
                    string comando = "select CNPJ from pessoajuridica where CNPJ = '" + cpfoucnpj + "';";
                    existe = bd.VerificaRetornaBool(comando);
                }
                //se existir, retorna true, se não, false


            }
            catch(Exception ex)
            {
                throw new Exception("Erro!" + ex);
            }
            return existe;
        }
        public void AtivarCliente(int idCliente)
        {
            try
            {
                bd.Conectar();
                string comando = "update cliente set statusCli='ativado' where idCliente = "+idCliente+"";
                bd.ExecutarComandoSQL(comando);
            }
            catch(Exception ex)
            {
                throw new Exception("Erro!" + ex);
            }
        }


    }

}
