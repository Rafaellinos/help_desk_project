using PIM4SEMVER1._0.DTO;
using PIM4SEMVER1._0.DAL;

namespace PIM4SEMVER1._0.BLL
{
    class CadastroClienteBLL
    {
        CadastroClienteDTO dtos;
        CadastroClienteDAO cb = new CadastroClienteDAO(); 
        //o nome agora é cadastro cliente DAO

        public void Inserirr(CadastroClienteDTO dto)
        {
            cb.Inserir(dto);
        }

        public CadastroClienteDTO Buscarr(string dto, string escolha)
        {
            dtos = new CadastroClienteDTO();

            dtos = cb.Buscar(dto, escolha);

            return dtos;
        }

        public void Atualizarr(CadastroClienteDTO dto)
        {
            cb.Atualizar(dto);
        }

        public void Excluirr(CadastroClienteDTO dto)
        {
            cb.Excluir(dto);
        }

        
        public bool CPFouCNPJexiste(string cpfoucnpj)
        {
            bool cpforcnpj = true; //se existir retorna true
            cpforcnpj = cb.CPFeCNPJExiste(cpfoucnpj);

            return cpforcnpj;
        }
        public void AtivarCliente(int idCliente)
        {
            cb.AtivarCliente(idCliente);
        }
    }
}
