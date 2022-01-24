using System.ComponentModel.DataAnnotations;
namespace Desafio.Model

{  
    public class Inquilino
    {
      [Key]
      public int idInquilino {get; set;}
      public string name {get; set;}
      public int idade {get; set;}
      public string sexo {get; set;}
      public int telefone {get; set;}
      public string email {get; set;}
  
    }
}