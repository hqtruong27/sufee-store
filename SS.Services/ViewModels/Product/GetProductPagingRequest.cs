using SS.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.Services.ViewModels.Product
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
        public int? CategoryId { get; set; }


    }
}
