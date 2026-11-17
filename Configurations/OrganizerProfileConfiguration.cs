using G_ASP_NET_80_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_80_EFCore02.Configurations
{
    public class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(p => p.Biography)
              .HasMaxLength(1000);

            builder.Property(p => p.WebsiteUrl)
                   .HasMaxLength(300);

            builder.Property(p => p.LogoUrl)
                   .HasMaxLength(300);
        }
    }
}
