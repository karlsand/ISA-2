#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISA_2_project.Data;

namespace ISA_2_project.Pages.Instructors
{
    public class DeleteModel : PageModel
    {
        private readonly ISA_2_project.Data.ISA_2_projectContext _context;

        public DeleteModel(ISA_2_project.Data.ISA_2_projectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Instructos Instructos { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instructos = await _context.Instructos.FirstOrDefaultAsync(m => m.ID == id);

            if (Instructos == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instructos = await _context.Instructos.FindAsync(id);

            if (Instructos != null)
            {
                _context.Instructos.Remove(Instructos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
