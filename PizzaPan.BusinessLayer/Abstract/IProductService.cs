using System.Collections.Generic;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategoryList();
        List<Product> GetAllPizza();

        Product GetCheapestPizza();
    }
}