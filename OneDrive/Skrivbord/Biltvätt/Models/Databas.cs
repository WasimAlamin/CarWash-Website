using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Databas: DbContext
    {
        public Databas() 
        {

            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = BilltvättDB.db");
        }
        public DbSet<Bokning> Bokningar { get; set; }

      
    }
}
