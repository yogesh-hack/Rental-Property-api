using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using rentalpropertyapi.Models;

namespace rentalpropertyapi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        public DbSet<Model> Data { get; set; }
    }

}
