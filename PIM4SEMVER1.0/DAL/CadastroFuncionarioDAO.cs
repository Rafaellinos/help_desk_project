using PIM4SEMVER1._0.DTO;
using System;
using System.Data;

namespace PIM4SEMVER1._0.DAL
{
    class CadastroFuncionarioDAO
    {
        private string nivelAcesso;
        AcessoMySQLDAO bdFunc;
        public void InserirFuncionario(CadastroFuncionarioDTO funcionarioDTO, int idcargo)
        {
            try
            {
                //string nivelAcesso;
                if(idcargo == 1)
                {
                    nivelAcesso = "Admin";
                }
                else if(idcargo == 2)
                {
                    nivelAcesso = "Operador";
                }
                else if(idcargo==3)
                {
                    nivelAcesso = "Técnico";
                }
                bdFunc = new AcessoMySQLDAO();
                bdFunc.Conectar();
                string comando = "INSERT INTO funcnionario(nome,cpf,telefone,email, deficiente, statusFun, cargo_idCargo) VALUES " +
                    "('" + funcionarioDTO.FuncNome + "','" + funcionarioDTO.FuncCPF + "','" + funcionarioDTO.FuncTelefone + "'," +
                    "'" + funcionarioDTO.FuncEmail + "','" + funcionarioDTO.FuncDeficiente + "','ativado',"+idcargo+")";
                //1-admin 2-operador 3-Técnico
                bdFunc.ExecutarComandoSQL(comando);

                string comando1 = "INSERT INTO login(usuario,senha,funcnionario_idFuncionario, nivelAcesso) VALUES " +
                    "('" + funcionarioDTO.Usuario + "','" + funcionarioDTO.Senha + "',LAST_INSERT_ID(), '"+nivelAcesso+"');";
                bdFunc.Conectar();
                bdFunc.ExecutarComandoSQL(comando1);
                /*
                string comando2 = "Insert into cargofuncionario(funcnionario_idFuncionario,cargo_idCargo) VALUES (LAST_INSERT_ID()," + idcargo + ");";
                bdFunc.Conectar();
                bdFunc.ExecutarComandoSQL(comando2);
                */
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no cadastro do funcionario: " + ex.Message);
            }
        }

        public void AtualizarFuncionario(CadastroFuncionarioDTO funcionarioDTO, int idCargo)
        {
            try
            {
                if (idCargo == 1)
                {
                    nivelAcesso = "Admin";
                }
                else if (idCargo == 2)
                {
                    nivelAcesso = "Operador";
                }
                else if (idCargo == 3)
                {
                    nivelAcesso = "Técnico";
                }
                bdFunc = new AcessoMySQLDAO();
                bdFunc.Conectar();

                /*
                string comando = "UPDATE funcnionario f " +
                    "JOIN login l ON f.idFuncionario = l.funcnionario_idFuncionario JOIN cargofuncionario j on f.idFuncionario" +
                    " = j.funcnionario_idFuncionario JOIN cargo c on c.idCargo = j.cargo_idCargo  SET f.nome = '"
                    + funcionarioDTO.FuncNome + "', f.cpf = '" + funcionarioDTO.FuncCPF + "', f.email ='" +
                     funcionarioDTO.FuncEmail + "', f.telefone = '" + funcionarioDTO.FuncTelefone + "', f.deficiente = '" +
                     funcionarioDTO.FuncDeficiente + "', l.usuario = '" + funcionarioDTO.Usuario + "'," +
                    " l.senha = '" + funcionarioDTO.Senha + "', l.nivelAcesso = '"+nivelAcesso+"', j.cargo_idCargo = '" + idCargo + "' where f.cpf =" +funcionarioDTO.FuncCPF;
                 */

                string comando = "update funcnionario f join login l on f.idFuncionario = l.funcnionario_idFuncionario join cargo c on c.idCargo = f.cargo_idCargo " +
                    " SET f.nome = '"
                    + funcionarioDTO.FuncNome + "', f.cpf = '" + funcionarioDTO.FuncCPF + "', f.email ='" +
                     funcionarioDTO.FuncEmail + "', f.telefone = '" + funcionarioDTO.FuncTelefone + "', f.deficiente = '" +
                     funcionarioDTO.FuncDeficiente + "', l.usuario = '" + funcionarioDTO.Usuario + "'," +
                    " l.senha = '" + funcionarioDTO.Senha + "', l.nivelAcesso = '" + nivelAcesso + "', f.cargo_idCargo = '" + idCargo + "' where f.cpf =" + funcionarioDTO.FuncCPF;

                bdFunc.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização do funcionario: " + ex.Message);
            }
        }

        public void ExcluirFuncionario(string cpf)
        {
            try
            {
                bdFunc = new AcessoMySQLDAO();
                bdFunc.Conectar();
                string comando = "UPDATE funcnionario set statusFun = 'desativado' where cpf ='"+cpf+"';";
                bdFunc.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o funcionario: " + ex.Message);
            }
        }
        
        public DataTable SelecionarTodosFuncionarios()//esse método exibe informações no grid
        {
            DataTable dtf = new DataTable(); // criando objeto do tipo data table dtf = data table funcionario
            try
            {
                bdFunc = new AcessoMySQLDAO();
                bdFunc.Conectar();
                /*
                dtf = bdFunc.RetDataTable("SELECT f.nome,f.cpf,f.telefone," +
                    "f.email,f.deficiente,f.statusFun,c.nome,l.usuario,l.senha from funcnionario f join cargofuncionario j on " +
                    "f.idFuncionario = j.funcnionario_idFuncionario join cargo c on c.idCargo = j.cargo_idCargo join login l on l.funcnionario_idFuncionario = f.idFuncionario");
                    */

                dtf = bdFunc.RetDataTable("select f.nome,f.cpf,f.telefone," +
                    "f.email,f.deficiente,f.statusFun,c.nome,l.usuario,l.senha from funcnionario f join cargo c on f.cargo_idCargo = c.idCargo join login l on " +
                    " l.funcnionario_idFuncionario = f.idFuncionario");
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao exibir todos funcionario: " + ex.Message);
            }

            return dtf;
        }
        public void AtivarFuncionario(string cpf)
        {
            try
            {
                bdFunc = new AcessoMySQLDAO();
                bdFunc.Conectar();
                string comando = "UPDATE funcnionario set statusFun = 'ativado' where cpf ='" + cpf + "';";
                bdFunc.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o funcionario: " + ex.Message);
            }
        }
    }
}