using Proj.Aplicacao.Entidades;
using Proj.Aplicacao.Interfaces;
using Proj.Infra.Dados;

namespace Proj.Infra.Repositorios
{
    public class PessoaRepository : EFRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ProjContexto dbContexto) : base(dbContexto)
        {
            
        }
    }
}