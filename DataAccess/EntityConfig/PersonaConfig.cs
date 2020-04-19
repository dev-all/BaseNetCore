using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Contracts.Entities;
namespace DataAccess.EntityConfig
{
    class PersonaConfig
    {
        ////ref https://docs.microsoft.com/es-es/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwithout-nrt
        public static void SetEntityBuilder(EntityTypeBuilder<Persona> entityBuilder)
        {

            //Configure default schema
            //entityBuilder.HasDefaultSchema("Admin");
            
            //Configure Column
            entityBuilder.ToTable("Personas");
            entityBuilder.HasKey(x => x.Id);            
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.Property(x => x.Id).UseIdentityColumn(1,1);
            entityBuilder.Property(x => x.Nombre).HasColumnType("varchar(150)");
            entityBuilder.Property(x => x.Apellido).HasColumnType("varchar(150)");
            entityBuilder.Property(x => x.NombreApellido).HasColumnType("varchar(300)");
            entityBuilder.Property(x => x.Documento).HasColumnType("varchar(200)");
            entityBuilder.Property(x => x.FechaCreacion).HasColumnType("Date");
        }
    }
}
