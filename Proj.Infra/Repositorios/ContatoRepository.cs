using Proj.Aplicacao.Entidades;
using Proj.Aplicacao.Interfaces;
using Proj.Infra.Dados;

namespace Proj.Infra.Repositorios
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(ProjContexto dbContexto) : base(dbContexto)
        {
            
        }
    }
}