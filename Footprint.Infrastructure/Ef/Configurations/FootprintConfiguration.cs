using System;
using System.Collections.Generic;
using System.Text;
using Itinere.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itinere.Infrastructure.Ef.Configurations
{
    public class FootprintConfiguration : IEntityTypeConfiguration<Footprint>
    {
        public void Configure(EntityTypeBuilder<Footprint> builder)
        {
            builder.HasKey(o => o.Id);
            builder.OwnsOne(
                o => o.MorningDung,
                dung =>
                {
                    dung.Property(o => o.Solidity);
                    dung.Property(o => o.Description);
                });
        }
    }
}
