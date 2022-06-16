using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Weeks_06.Pages
{
    public class Etudiant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le Prenom est obligatoire")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Le Nom est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Veuillez entrée une moyenne")]
        public int Moyenne { get; set; }
        [Required(ErrorMessage = "Veuillez faire une selection")]
        public string Programme { get; set; }
    }
}