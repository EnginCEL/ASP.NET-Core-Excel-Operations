using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Excel_Operations.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QJKK06K;Database=CoreExcelDB; Integrated Security = SSPI");
        }
        public virtual DbSet<PersonalViewModel> Personal { get; set; }

    }
}
