using SS.Services.Common;
using SS.Services.ViewModels.Product;
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
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<int> Delete(int productId);
        Task<PagedRequest<ProductViewModel>> GettAllProductPaging(GetProductPagingRequest request);


    }
}
