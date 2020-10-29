using SS.Services.Dtos;
using SS.Services.Interface.IProductServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services.Interface.IProductServices
{
    public interface IClientProduct
    {
        Task<PagedRequest<ProductViewModel>> GettProuctByCategoryId(GetProductPagingRequest request);
    }
}