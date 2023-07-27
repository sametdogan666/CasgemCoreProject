using System.Collections.Generic;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.ViewModels
{
    public class CategoryProductViewModel
    {
        public List<Category> Categories { get; set; }
        public List<IEnumerable<Product>> ProductsPerCategory { get; set; }

    }
}