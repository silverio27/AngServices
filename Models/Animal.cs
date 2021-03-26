using System.ComponentModel.DataAnnotations;

namespace AngServices.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeDoDono { get; set; }
        public string Raca { get; set; }
    }
}