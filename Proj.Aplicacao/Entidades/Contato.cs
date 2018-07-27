namespace Proj.Aplicacao.Entidades
{
    public class Contato
    {
        public int Id { get; set; }
        
        // Melhorar: Tentar usar apenas um dos contatos por classe;
        // Usar ENUM para definir os tipos de contatos;
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
    }
}