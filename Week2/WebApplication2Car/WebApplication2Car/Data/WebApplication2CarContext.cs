using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2Car.Models;

namespace WebApplication2Car.Data
{
    public class WebApplication2CarContext : DbContext
    {
        public WebApplication2CarContext (DbContextOptions<WebApplication2CarContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2Car.Models.Car> Car { get; set; } = default!;
    }
}
