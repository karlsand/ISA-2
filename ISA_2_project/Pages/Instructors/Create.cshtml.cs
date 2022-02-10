#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISA_2_project.Data;

namespace ISA_2_project.Pages.Instructors
{
    public class CreateModel : PageModel
    {
        private readonly ISA_2_project.Data.ISA_2_projectContext _context;

        public CreateModel(ISA_2_project.Data.ISA_2_projectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Instructos Instructos { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Instructos.Add(Instructos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
