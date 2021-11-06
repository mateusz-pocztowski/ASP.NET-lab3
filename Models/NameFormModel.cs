using System.ComponentModel.DataAnnotations;

namespace ASP.NET_lab3.Models
{
    public class NameFormModel
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Ilość powtórzeń")]
        [Required]
        [Range(1, 5)]
        public int Repeats { get; set; }
    }
}
