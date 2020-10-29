using SS.Services.Dtos;
using SS.Services.Interface.IProductServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services.Interface.IProductServices
{
    public interface IManageProductServices
    {
        Task<int> Create(ProductCreateViewModel model);
        Task<int> Edit(ProductEditViewModel model);
        Task<bool> UpdatePrice(int productId, int newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<int> Delete(int productId);
        Task<PagedRequest<ProductViewModel>> GettAllProductPaging(GetProductPagingRequest request);


    }
}
