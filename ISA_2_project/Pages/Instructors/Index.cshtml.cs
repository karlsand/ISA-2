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
    public class IndexModel : PageModel
    {
        private readonly ISA_2_project.Data.ISA_2_projectContext _context;

        public IndexModel(ISA_2_project.Data.ISA_2_projectContext context)
        {
            _context = context;
        }

        public IList<Instructos> Instructos { get;set; }

        public async Task OnGetAsync()
        {
            Instructos = await _context.Instructos.ToListAsync();
        }
    }
}
