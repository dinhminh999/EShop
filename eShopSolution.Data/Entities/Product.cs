using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entities
{
    //[Table("Products")]
    public class Product
    {
        public int Id { set; get; }
        public Decimal Price { set; get; }
        public Decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        [Required]
        public string SeoAlias { set; get; }
    }
}
