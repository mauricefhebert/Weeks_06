using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Weeks_06.Pages
{
    public class Etudiant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le Prenom est obligatoire")]
        public string Prenom { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int Moyenne { get; set; }
        [Required]
        public string Programme { get; set; }
    }
}