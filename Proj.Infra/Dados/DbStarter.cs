using System;
using System.Linq;
using Proj.Aplicacao.Entidades;

namespace Proj.Infra.Dados
{
    public static class DbStarter
    {

        public static void Start(ProjContexto contexto)
        {
            // Se houver alguma pessoa armazenada no banco, saia do metodo;
            if (contexto.Pessoas.Any()) return;
            
            Console.WriteLine("\n\n\nEntrou!!!!!!!!!!!!!\n\n\n");
            var pessoas = new Pessoa[]{
                
                new Pessoa
                {
                    Nome = "João Carlos",
                    Cpf = "00372313752",
                    DataNasc = DateTime.Parse("1996/06/25"),
                    Email = "joao@email.com"
                },
                new Pessoa
                {
                    Nome = "Maria Silva",
                    Cpf = "00372313753",
                    DataNasc = DateTime.Parse("1995/04/03"),
                    Email = "maria@email.com"
                }
            };
            
            contexto.AddRange(pessoas);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Celular = "27998855521",
                    Facebook = "joao25FB",
                    Email = "joao@email.com",
                    Pessoa = pessoas[0]
                },
                new Contato
                {
                    Telefone = "2732285937",
                    Twitter = "@MarizinhaDúuuJC",
                    Email = "maria@email.com",
                    Pessoa = pessoas[1]
                }
            };
            
            contexto.AddRange(contatos);

            contexto.SaveChanges();
        }
    }
}