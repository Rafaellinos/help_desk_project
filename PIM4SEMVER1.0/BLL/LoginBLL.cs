using PIM4SEMVER1._0.DAL;

namespace PIM4SEMVER1._0.BLL
{
    class LoginBLL
    {

        LoginDAO cb = new LoginDAO();

        public bool Logiin(string usu, string senha)
        {
            bool result = false;

            result = cb.Login(usu, senha);
            
            return result;
        }
        public bool CheckStatus(string usu)
        {
            bool status = false;
            status = cb.CheckStatus(usu);
            return status;
        }
    }
}