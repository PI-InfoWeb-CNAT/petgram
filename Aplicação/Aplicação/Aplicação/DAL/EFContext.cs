using Aplicação.Migrations;
using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Aplicação.DAL
{
    public class EFContext : DbContext
    {
        public EFContext() : base("conectardb")
        {
            Database.SetInitializer<EFContext>(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Postagem> Postagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}