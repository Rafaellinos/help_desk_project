using System.Collections.Generic;

namespace PIM4SEMVER1._0.DAL
{
    class LoginDAO
    {
        AcessoMySQLDAO bd = new AcessoMySQLDAO();

        //verifica se usuario e senha existem, se sim, true, se não, false
        public bool Login(string usu, string senha)
        {
            bool result = false;
            try
            {

                bd.Conectar();
                string comando = "select usuario, senha from login where usuario = '" + usu + "' and senha = '" + senha + "'";
                result = bd.VerificaRetornaBool(comando);
            }
            catch
            {

            }
            return result;
        }

        //checa status do funcionario, se está ativo ou não. Se estiver desativado, retorna falso e barra o login
        public bool CheckStatus(string usu)
        {
            bool checkStatus = false;
            string Status;
            bd.Conectar();
            string comando = "select f.statusFun from funcnionario f join login l " +
            "on idFuncionario = funcnionario_idFuncionario where usuario = '" + usu + "';";
            Status = bd.RetornaNomeFuncionario(comando);
            if(Status.ToString()=="desativado")
            {
                checkStatus = false;
            }
            else
            {
                checkStatus = true;
            }
            return checkStatus;
        }

    }
}