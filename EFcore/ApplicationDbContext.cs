using EFcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFcore
{
   class ApplicationDbContext: DbContext    
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("/////////");
           

        }
    }
}
