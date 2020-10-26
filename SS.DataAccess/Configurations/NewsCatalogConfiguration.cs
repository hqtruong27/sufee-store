using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Configurations
{
    public class NewsCatalogConfiguration : IEntityTypeConfiguration<NewsCatalog>
    {
        public void Configure(EntityTypeBuilder<NewsCatalog> builder)
        {
            builder.ToTable("NewsCatalogs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
