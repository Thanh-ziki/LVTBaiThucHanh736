using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<MvcMovie.Models.Animal> Animal { get; set; } = default!;
    }

}
    