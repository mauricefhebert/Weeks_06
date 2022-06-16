using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Weeks_06.Pages.AddEtudiant
{
    public class Create : PageModel
    {
        [BindProperty]
        public Etudiant etudiants { get; set; }

        public List<SelectListItem> mySkills = new List<SelectListItem>() {
        new SelectListItem { Text = "Informatique", Value = "Informatique" },
        new SelectListItem { Text = "Administration", Value = "Administration" },
        new SelectListItem { Text = "Enseignement", Value = "Enseignement" }
        };
        public void OnGet()
        {
            etudiants = new Etudiant();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Create of the Sql Connection string
            using (var cn = new SqlConnection("Data Source=.;Initial Catalog=cegep; Integrated Security=true;"))
            {
                //Open the connection
                cn.Open();
                //Create the query
                string query = @"INSERT INTO etudiant (prenom, nom, moyenne, programme)
                                VALUES (@prenom, @nom, @moyenne, @programme)";
                //Create the commande
                var cmd = new SqlCommand(query, cn);

                //Create the parameter
                cmd.Parameters.AddWithValue("@prenom", etudiants.Prenom);
                cmd.Parameters.AddWithValue("@nom", etudiants.Nom);
                cmd.Parameters.AddWithValue("@moyenne", etudiants.Moyenne);
                cmd.Parameters.AddWithValue("@programme", etudiants.Programme);

                //Execute the command
                cmd.ExecuteNonQuery();
            }
            //Return to the index
            return RedirectToPage("/Index");
        }
    }
}