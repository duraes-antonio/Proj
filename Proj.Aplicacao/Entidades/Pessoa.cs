using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proj.Aplicacao.Entidades
{
    public class Pessoa
    {
        public int Idewfenix { get; set; }
        
        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }
        
        [Required]
        public DateTime DataNasc { get; set; }
        
        [Required]
        public DateTime DataCadastro { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        public Endereco Endereco { get; set; }
        
        public ICollection<Contato> Contatos { get; set; }
    }
}