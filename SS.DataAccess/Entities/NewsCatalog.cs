using SS.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class NewsCatalog
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public List<News> News { get; set; }
        public List<NewsCatalogTranslation> NewsCatalogTranslations { get; set; }
    }
}
