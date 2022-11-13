using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRYPFDO.Models;

namespace TRYPFDO.Data
{
    public class TRYPFDOContext : DbContext
    {
        public TRYPFDOContext (DbContextOptions<TRYPFDOContext> options)
            : base(options)
        {
        }

        public DbSet<TRYPFDO.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<TRYPFDO.Models.Rol> Roles { get; set; }
    }
}
