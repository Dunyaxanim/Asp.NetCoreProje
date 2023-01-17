using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPIDemo.DataAccessLayer
{
    public class Context2 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7563H9T;database=CoreBlogDbApi2; integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
