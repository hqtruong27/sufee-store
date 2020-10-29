using SS.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.Services.Interface.IProductServices.Dtos
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
        public int? CategoryId { get; set; }


    }
}
