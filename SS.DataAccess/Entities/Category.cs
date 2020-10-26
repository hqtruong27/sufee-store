using SS.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }

        public List<Product> Products { get; set; }
}
}
