using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //app config
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "Home Title", Value = "This is home Page Sufee" }
            );

            //language
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = "vi-VN", Name = "Vietnamese", IsDefault = true },
                new Language { Id = "en-US", Name = "English", IsDefault = false }
                );

            //Category
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Acticve,
                });
            //category Translation
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation { Id = 1, CategoryId = 1, Name = "Iphone", LanguageId = "vi-VN", SeoAlias = "iphone", SeoDescription = "Danh mục Iphone", SeoTitle = "Danh mục Iphone" },
                new CategoryTranslation { Id = 2, CategoryId = 1, Name = "Iphone", LanguageId = "en-US", SeoAlias = "iphone", SeoDescription = "Category Iphone", SeoTitle = "Category Iphone" }
                );
            //Product
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   PriceIn = 10000,
                   Price = 12000,
                   Stock = 0,
                   ViewCount = 0,
                   CategoryId = 1,
               });
            //Product translation
            modelBuilder.Entity<ProductTranslation>().HasData(
               new ProductTranslation
               {
                   Id = 1,
                   ProductId = 1,
                   Name = "Iphone 7",
                   LanguageId = "vi-VN",
                   SeoAlias = "iphone-7",
                   SeoDescription = "Đây là Iphone 7",
                   SeoTitle = "sản phẩm Iphone 7",
                   Details = "Mô tả về ip 7",
                   Description = "VN",
               },
               new ProductTranslation { Id = 2, ProductId = 1, Name = "Iphone 7", LanguageId = "en-US", SeoAlias = "iphone-7", SeoDescription = "This is Iphone 7", SeoTitle = "This is Iphone 7", Details = "Description Ip 7", Description = "EN" }
               );

            //User Sample
            const string roleId = "0B39A049-7277-4F28-9DDF-148907D7F987";
            const string adminId ="3973E3F1-086C-4AFF-B484-431013385161";
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "Admin",
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "Hqtruong27",
                NormalizedUserName = "Hqtruong27",
                Email = "hqtruong27@gmail.com",
                NormalizedEmail = "hqtruong27@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "mepbphhond"),
                SecurityStamp = string.Empty,
                FullName = "Hoang Truong",
                Birthday = new DateTime(1998, 07, 22)
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
