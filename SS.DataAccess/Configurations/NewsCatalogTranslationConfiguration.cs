using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Configurations
{
    public class NewsCatalogTranslationConfiguration : IEntityTypeConfiguration<NewsCatalogTranslation>
    {
        public void Configure(EntityTypeBuilder<NewsCatalogTranslation> builder)
        {
            builder.ToTable("NewsCatalogTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(250);
            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            builder.Property(x => x.SeoDescription).HasMaxLength(500).IsRequired(false);

            builder.HasOne(x => x.NewsCatalog).WithMany(x => x.NewsCatalogTranslations).HasForeignKey(x => x.NewsCatalogId);
            builder.HasOne(x => x.Language).WithMany(x => x.NewsCatalogTranslations).HasForeignKey(x => x.Language);
        }
    }
}
