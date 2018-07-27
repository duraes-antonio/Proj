using System.ComponentModel.DataAnnotations;

namespace Proj.Aplicacao.Entidades
{
    public class Contato
    {
        public int Id { get; set; }
        
        // Melhorar: Tentar usar apenas um dos contatos por classe;
        // Usar ENUM para definir os tipos de contatos;
        
        [MaxLength(15)]
        public string Celular { get; set; }
        
        [MaxLength(15)]
        public string Telefone { get; set; }
        
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(100)]
        public string Facebook { get; set; }
        
        [MaxLength(100)]
        public string Instagram { get; set; }
        
        [MaxLength(100)]
        public string Twitter { get; set; }
    }
}