using Microsoft.EntityFrameworkCore;
using DataAccess.Contracts;
using DataAccess.Contracts.Entities;
using DataAccess.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    //por defecto de hereda de DbContext
    public class AppDBContext : DbContext , IAppDBContext
    //IdentityDbContext<AppUser>
    {

        public DbSet<Persona> Personas { get; set; }

        public AppDBContext(DbContextOptions options):base(options)
        {

        }
        public AppDBContext() 
        {

        }

        //sobrecarga del contexto al crear la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            PersonaConfig.SetEntityBuilder(modelBuilder.Entity<Persona>());

            base.OnModelCreating(modelBuilder);

        }


    }
}
