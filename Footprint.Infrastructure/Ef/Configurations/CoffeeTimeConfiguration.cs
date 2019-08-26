using System;
using System.Collections.Generic;
using System.Text;
using Itinere.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itinere.Infrastructure.Ef.Configurations
{
    public class CoffeeTimeConfiguration : IEntityTypeConfiguration<CoffeeTime>
    {
        public void Configure(EntityTypeBuilder<CoffeeTime> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}
