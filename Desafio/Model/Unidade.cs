using System.ComponentModel.DataAnnotations;
namespace Desafio.Model
{
    public class Unidade
    {
        [Key]
        public int idUnidade {get; set;}
        public int identificacao {get; set;}
        public string proprietario {get; set;}
        public string condominio {get; set;}
        public int cep {get; set;}
        public int numero {get; set;}
        public string rua {get; set;}
        public string bairro {get; set;}
        public string cidade {get; set;}
        public string estado {get; set;}
    }
}