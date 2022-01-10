using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options):base (options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}
