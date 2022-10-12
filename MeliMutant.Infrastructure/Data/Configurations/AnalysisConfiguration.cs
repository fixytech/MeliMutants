using MeliMutant.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Infrastructure.Data.Configurations
{
    public class AnalysisConfiguration : IEntityTypeConfiguration<Analysis>
    {
        public void Configure(EntityTypeBuilder<Analysis> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder
                .Property(x => x.Dna)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(x => x.Result)
                .IsRequired();

            builder
                .ToTable("analysis");
        }
    }
}
