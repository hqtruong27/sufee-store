using SS.DataAccess.EF;
using SS.Services.Interface.IProductServices;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SS.Services.Common;
using SS.Services.ViewModels.Product;

namespace SS.Services.Services.ProductServices
{
    public class ClientProductServices : IClientProduct
    {
        private readonly ApplicationDbContext _context;
        public ClientProductServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetProduct()
        {
            var strQuery =  (from p in _context.Products
                                  join pt in _context.ProductTranslations
                                  on p.Id equals pt.ProductId
                                  join c in _context.Categories
                                  on p.CategoryId equals c.Id
                                  select new { p, pt });
            
            var data = await strQuery.Select(x => new ProductViewModel()
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
            return data;
        }

        public async Task<PagedRequest<ProductViewModel>> GettProuctByCategoryId(GetProductPagingRequest request)
        {
            var strQuery = from p in _context.Products
                           join pt in _context.ProductTranslations
                           on p.Id equals pt.ProductId
                           join c in _context.Categories
                           on p.CategoryId equals c.Id

                           select new { p, pt };
            if (request.CategoryId.HasValue == true && request.CategoryId.Value > 0)
            {
                strQuery = strQuery.Where(x => x.p.CategoryId == request.CategoryId);
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
    }
}
