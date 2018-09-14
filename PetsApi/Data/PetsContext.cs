using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PetsApi.Models
{
    public class PetsContext : DbContext
    {
        public PetsContext (DbContextOptions<PetsContext> options)
            : base(options)
        {
        }

        public DbSet<PetsApi.Models.Pet> Pet { get; set; }
    }
}
