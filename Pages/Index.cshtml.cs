using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weeks_06.Pages
{
    public class IndexModel : PageModel
    {
        //Data Source =.; Initial Catalog = cegep; Integrated Security = True
        public List<Etudiant> etudiants { get; set; }

        public void OnGet()
        {
            //Crate the list
            etudiants = new List<Etudiant>();
            //Create sql connection
            using (var cn = new SqlConnection("Data Source=.;Initial Catalog=cegep; Integrated Security=true;"))
            {
                //Open the connection
                cn.Open();
                //Create query
                string query = "SELECT * FROM etudiant";
                //Create the command
                using (var cmd = new SqlCommand(query, cn))
                {
                    //Create the reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            etudiants.Add(new Etudiant()
                            {
                                Id = (int)reader.GetValue(0),
                                Prenom = (string)reader.GetValue(1),
                                Nom = (string)reader.GetValue(2),
                                Moyenne = (int)reader.GetValue(3),
                                Programme = (string)reader.GetValue(4)
                            });
                        };
                    }
                }
            }
        }
    }
}