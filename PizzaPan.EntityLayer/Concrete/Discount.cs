using System;
using System.Collections.Generic;

namespace PizzaPan.EntityLayer.Concrete
{
    public class Discount
    {
        public int Id { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set;}
    }
}