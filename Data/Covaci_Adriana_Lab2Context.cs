using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Covaci_Adriana_Lab2.Models;
using System.Reflection.Metadata;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }

        public DbSet<Covaci_Adriana_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Covaci_Adriana_Lab2.Models.Borrowing>? Borrowing { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //  modelBuilder.Entity<boo>()
        //    .HasMany(e => e.Posts)
        //  .WithOne(e => e.Blog)
        //.HasForeignKey(e => e.BlogId)
        // .HasPrincipalKey(e => e.Id);
    }
    }

