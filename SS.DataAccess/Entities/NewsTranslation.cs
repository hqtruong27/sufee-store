using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class NewsTranslation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int NewsId { get; set; }
        public string LanguageId{ get; set; }

        public News News { get; set; }
        public Language Language{ get; set; }
    }
}
