#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISA_2_project.Data;

namespace ISA_2_project.Pages.Instructors
{
    public class EditModel : PageModel
    {
        private readonly ISA_2_project.Data.ISA_2_projectContext _context;

        public EditModel(ISA_2_project.Data.ISA_2_projectContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Instructos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructosExists(Instructos.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InstructosExists(string id)
        {
            return _context.Instructos.Any(e => e.ID == id);
        }
    }
}
