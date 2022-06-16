using System.ComponentModel.DataAnnotations;

namespace Weeks_06.Pages
{
    public class Etudiant
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int Moyenne { get; set; }
        [Required]
        public string Programme { get; set; }
    }
}