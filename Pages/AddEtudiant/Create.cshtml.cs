using System;
using System.Collections.Generic;
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


            return RedirectToPage("/Index");
        }
    }
}