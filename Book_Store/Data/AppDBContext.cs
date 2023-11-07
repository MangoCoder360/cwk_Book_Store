using System;
using Book_Store.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Data
{
    public class AppDBContext : DbContext
	{
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Book_Store.db");
        }

        public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
	}
}

