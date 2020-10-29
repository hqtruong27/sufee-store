using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class Language
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
        public List<NewsCatalogTranslation> NewsCatalogTranslations { get; set; }
        public List<NewsTranslation> NewsTranslations { get; set; }
    }
}
