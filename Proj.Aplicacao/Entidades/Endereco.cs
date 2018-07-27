namespace Proj.Aplicacao.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        
        // integrar sistema ViaCEP com captura de CEP
        public string Cep { get; set; }

        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        
        // Usar ENUm para pegar estado;
        public string Estado { get; set; }
    }
}