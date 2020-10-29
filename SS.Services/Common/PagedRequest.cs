using System;
using System.Collections.Generic;
using System.Text;

namespace SS.Services.Common
{
    public class PagedRequest<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
