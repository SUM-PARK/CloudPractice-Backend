using System;
using System.Collections.Generic;
using System.Text;
using Itinere.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itinere.Infrastructure.Ef.Configurations
{
    public class DungConfiguration : IEntityTypeConfiguration<Dung>
    {
        public void Configure(EntityTypeBuilder<Dung> builder)
        {
            builder.HasKey(o => o.Solidity);
        }
    }
}
