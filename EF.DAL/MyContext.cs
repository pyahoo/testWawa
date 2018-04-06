using EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF.DAL
{
    public class MyContext : DbContext
    {
        public MyContext():base("MyDB")
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove(
                new PluralizingTableNameConvention());
        }

    }
}
