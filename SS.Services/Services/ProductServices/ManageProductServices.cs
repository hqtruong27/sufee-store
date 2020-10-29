using Microsoft.EntityFrameworkCore;
using SS.DataAccess.EF;
using SS.DataAccess.Entities;
using SS.Services.Interface.IProductServices;
using SS.Utilities.Exceptions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SS.Services.Common;
using SS.Services.ViewModels.Product;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;

namespace SS.Services.Services.ProductServices
{
    public class ManageProductServices : IManageProductServices
    {
        private readonly ApplicationDbContext _context;
        public ManageProductServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddViewCount(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(ProductCreateViewModel model)
        {
            var product = new Product()
            {
                PriceIn = model.PriceIn,
                Price = model.Price,
                DateCreated = DateTime.Now,
                CategoryId = model.CategoryId,
                Stock = model.Stock,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation(){
                        Name = model.Name,Details = model.Details,
                        Description = model.Description,
                        SeoDescription = model.SeoDescription,
                        SeoTitle = model.SeoTitle,
                        SeoAlias = model.SeoAlias,
                        LanguageId = model.LanguageId
                    },
                }
            };
            //Save Image
            await _context.Products.AddAsync(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new SufeeException($"Can't find a product: {productId}");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit(ProductEditViewModel model)
        {
            var product = await _context.Products.FindAsync(model.Id);
            var proTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == model.Id && x.LanguageId == model.LanguageId);
            if (product == null || proTranslation == null) throw new SufeeException($"Cannot find a Product with id: {model.Id}");
            //do update
            proTranslation.Name = model.Name;
            proTranslation.Description = model.Description;
            //....
            //Save chagne
            return await _context.SaveChangesAsync();

        }

        public async Task<PagedRequest<ProductViewModel>> GettAllProductPaging(GetProductPagingRequest request)
        {
            var strQuery = from p in _context.Products
                           join pt in _context.ProductTranslations
                           on p.Id equals pt.Id
                           join c in _context.Categories
                           on p.CategoryId equals c.Id

                           select new { p, pt };
            if (!String.IsNullOrEmpty(request.Keyword))
            {
                strQuery = strQuery.Where(x => x.pt.Name.Contains(request.Keyword));
            }
            if (request.CategoryIds.Count() > 0)
            {
                strQuery = strQuery.Where(x => request.CategoryIds.Contains(x.p.CategoryId));
            }
            int totalRow = await strQuery.CountAsync();
            var data = await strQuery.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    PriceIn = x.p.PriceIn,
                    SeoTitle = x.pt.SeoTitle,
                    CategoryId = x.p.CategoryId
                }).ToListAsync();
            //select and projection
            var pageResult = new PagedRequest<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new SufeeException($"Cannot find a Product with id: {productId}");
            //do update
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }

        //
        //private async Task<string> SaveFile(IFormFile file)
        //{
        //    var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        //    var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
        //    await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
        //    return fileName;
        //}
    }
}
