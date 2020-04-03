using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderDate { get; set; }
        public int UserId { get; set; }
    }
}
