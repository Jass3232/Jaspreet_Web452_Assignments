using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPants.Models;

namespace MvcPants.Data
{
    public class MvcPantsContext : DbContext
    {
        public MvcPantsContext(DbContextOptions<MvcPantsContext> options)
            : base(options)
        {
        }

        public DbSet<Pants> Pants { get; set; }
    }
}