using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Covaci_Adriana_Lab2.Models;

namespace Covaci_Adriana_Lab2.Data
{
    public class Covaci_Adriana_Lab2Context : DbContext
    {
        public Covaci_Adriana_Lab2Context (DbContextOptions<Covaci_Adriana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Covaci_Adriana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Covaci_Adriana_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Covaci_Adriana_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Covaci_Adriana_Lab2.Models.Category>? Category { get; set; }
    }
}
