using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_GOL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_GOL.Infra.DataAccess
{
    public class AirplaneMap : IEntityTypeConfiguration<Airplane>
    {
        public void Configure(EntityTypeBuilder<Airplane> builder)
        {
            builder.ToTable("Airplane");
            builder.HasKey(r => r.IdAviao);
            builder.Property(r => r.IdAviao).HasColumnName("IdAviao").HasColumnType("BIGINT");
            builder.Property(r => r.CodigoAviao).HasColumnName("CodigoAviao").HasColumnType("VARCHAR").HasMaxLength(20);
            builder.Property(r => r.ModeloAviao).HasColumnName("ModeloAviao").HasColumnType("VARCHAR").HasMaxLength(100);
            builder.Property(r => r.QtdPassageiros).HasColumnName("QtdPassageiros").HasColumnType("INT");
            builder.Property(r => r.DataCriacao).HasColumnName("DataCriacao").HasColumnType("DATETIME");
        }
    }
}
