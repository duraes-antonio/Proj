using System.ComponentModel.DataAnnotations;

namespace Proj.Aplicacao.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        
        // integrar sistema ViaCEP com captura de CEP
        
        [Required]
        [MaxLength(8)]
        public string Cep { get; set; }

        [Required]
        public int Numero { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string Logradouro { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }
        
        // Usar ENUm para pegar estado;
        public string Estado { get; set; }
    }
}