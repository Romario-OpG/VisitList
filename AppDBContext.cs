using Pomelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace visit_list
{
   public class AppDBContext : DbContext
   {
      public DbSet<Visit> Visits { get; set; }
      public DbSet<Student> Students { get; set; }

      public AppDBContext()
      {
         Database.EnsureCreated();
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         var connectionString = File.ReadAllText("connection.txt");
         optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
      }
   }
}
