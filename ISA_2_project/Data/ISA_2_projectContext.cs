#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ISA_2_project.Data
{
    public class ISA_2_projectContext : DbContext
    {
        public ISA_2_projectContext (DbContextOptions<ISA_2_projectContext> options)
            : base(options)
        {
        }

        public DbSet<ISA_2_project.Data.Instructos> Instructos { get; set; }
    }
}
