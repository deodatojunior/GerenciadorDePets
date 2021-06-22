using CadastroPet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPet.Database
{
    public class Context : DbContext
    {
        public Context() : base("MySQLConnectionString")
        {

        }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Pet>()
                .ToTable("Pet");

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));
        }
    }
}
