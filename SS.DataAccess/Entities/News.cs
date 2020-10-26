using SS.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class News
    {
        public int Id { get; set; }
        public int CountView { get; set; }
        public NewsStatus Status { get; set; }

        public NewsCatalog NewsCatalog { get; set; }

        public List<NewsTranslation> NewsTranslations { get; set; }
    }
}
