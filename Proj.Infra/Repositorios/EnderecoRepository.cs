using Proj.Aplicacao.Entidades;
using Proj.Aplicacao.Interfaces;
using Proj.Infra.Dados;

namespace Proj.Infra.Repositorios
{
    public class EnderecoRepository : EFRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ProjContexto dbContexto) : base(dbContexto)
        {
            
        }
    }
}