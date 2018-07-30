using System.ComponentModel.DataAnnotations;

namespace Proj.Aplicacao.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        // Integrar sistema ViaCEP com captura de CEP
        
        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        
        // Usar ENUm para pegar estado;
        public string EstadoSigla { get; set; }
    }
}