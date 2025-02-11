using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models;


namespace api.Data
{
    public class ApplicationDBContext : DbContext  // inherit from DbContext
    {
        public ApplicationDBContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Comment> Comments { get; set; }  // Fixed typo
    }
}
