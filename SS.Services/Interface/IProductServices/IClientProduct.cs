using SS.Services.Common;
using SS.Services.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services.Interface.IProductServices
{
    public interface IClientProduct
    {
        Task<PagedRequest<ProductViewModel>> GettProuctByCategoryId(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetProduct();
    }
}