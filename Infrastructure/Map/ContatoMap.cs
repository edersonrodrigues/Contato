using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Map
{
    internal sealed class ContatoMap: IEntityTypeConfiguration<ContatoEntity>
    {
        public void Configure(EntityTypeBuilder<ContatoEntity> builder)
        {
            builder.ToTable("Contato");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasColumnName("Id")
            .IsRequired();
        }
    }
}
