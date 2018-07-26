using System;
using System.Collections;
using System.Collections.Generic;

namespace Dominio.Aplicacao.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
        public ICollection<Contato> Contatos { get; set; }
    }
}