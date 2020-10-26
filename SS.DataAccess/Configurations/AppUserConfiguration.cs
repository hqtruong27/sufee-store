using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.FullName).HasMaxLength(250).IsRequired();
        }
    }
}
