using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using spaAppClassLib.Data.Models;

namespace spaAppClassLib.Data
{
    public class GoodBooksDbContext : DbContext
    {
        public GoodBooksDbContext() { }
        public GoodBooksDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookReview> BookReviews { get; set; }
    }
}
