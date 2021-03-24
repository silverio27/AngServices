using System;
using System.ComponentModel.DataAnnotations;

namespace AngServices.Models
{
    public class Pessoa
    {
        [Key] 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

    }
}