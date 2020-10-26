using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Configurations
{
    public class NewsTranslationConfiguration : IEntityTypeConfiguration<NewsTranslation>
    {
        public void Configure(EntityTypeBuilder<NewsTranslation> builder)
        {
            builder.ToTable("NewsTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Content).IsRequired();

            builder.HasOne(x => x.News).WithMany(x => x.NewsTranslations).HasForeignKey(x => x.NewsId);
            builder.HasOne(x => x.Language).WithMany(x => x.NewsTranslations).HasForeignKey(x => x.LanguageId);
        }
    }
}
