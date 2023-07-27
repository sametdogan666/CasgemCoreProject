using System.Collections.Generic;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public List<Product> GetProductsWithCategory();
        public List<Product> GetAllPizza();
        public Product GetCheapestPizza();
        List<IEnumerable<Product>> ProductsPerCategory();
    }
}