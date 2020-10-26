using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class NewsCatalogTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public int NewsCatalogId { get; set; }

        public NewsCatalog NewsCatalog { get; set; }
        public Language Language { get; set; }
    }
}
