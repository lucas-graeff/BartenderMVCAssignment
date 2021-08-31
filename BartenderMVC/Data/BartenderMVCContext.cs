using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BartenderMVC.Models;

namespace BartenderMVC.Data
{
    public class BartenderMVCContext : DbContext
    {
        public BartenderMVCContext (DbContextOptions<BartenderMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BartenderMVC.Models.Cocktail> Cocktail { get; set; }
        public DbSet<BartenderMVC.Models.Queue> Queue { get; set; }
    }
}
