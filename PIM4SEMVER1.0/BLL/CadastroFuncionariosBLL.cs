using System.Data;
using PIM4SEMVER1._0.DAL;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.BLL
{
    class CadastroFuncionariosBLL
    {
        CadastroFuncionarioDAO DAL = new CadastroFuncionarioDAO();

        public void InserirFuncionario (CadastroFuncionarioDTO dtoFunc, int Idcargo)
        {
            DAL.InserirFuncionario(dtoFunc, Idcargo);
        }

        public void AtualizarFuncionario(CadastroFuncionarioDTO dtoFunc, int Idcargo)
        {
            DAL.AtualizarFuncionario(dtoFunc, Idcargo);
        }
        public void ExcluirFuncionario(string cpf)
        {
            DAL.ExcluirFuncionario(cpf);
        }
        public void AtivarFuncionario(string cpf)
        {
            DAL.AtivarFuncionario(cpf);
        }
        public DataTable SelecionarTodosFuncionarios()
        {
            DataTable Funcionarios = new DataTable();
            Funcionarios = DAL.SelecionarTodosFuncionarios();

            return Funcionarios;
        }

    }
}
