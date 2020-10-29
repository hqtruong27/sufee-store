using System;
using System.Collections.Generic;
using System.Text;

namespace SS.Services.Interface.IProductServices.Dtos
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { get; set; }
        public decimal PriceIn { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
    public class ProductCreateViewModel
    {
        public decimal Price { get; set; }
        public decimal PriceIn { get; set; }
        public int Stock { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
    public class ProductEditViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int Stock { get; set; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }

    }
    public class ProductDeleteViewModel
    {

    }
}
