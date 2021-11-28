using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Markoski_Stefan_Lab8.Models;

namespace Markoski_Stefan_Lab8.Data
{
    public class Markoski_Stefan_Lab8Context : DbContext
    {
        public Markoski_Stefan_Lab8Context (DbContextOptions<Markoski_Stefan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Markoski_Stefan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Markoski_Stefan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Markoski_Stefan_Lab8.Models.BookCategory> BookCategory { get; set; }

        public DbSet<Markoski_Stefan_Lab8.Models.Category> Category { get; set; }
    }
}
