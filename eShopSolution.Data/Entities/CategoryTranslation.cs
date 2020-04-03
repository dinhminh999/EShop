using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int Name { get; set; }
        public int SeoDescription { get; set; }
        public int SeoTitle { get; set; }
        public int LanguageId { get; set; }
        public int SeoAlias { get; set; }
    }
}
