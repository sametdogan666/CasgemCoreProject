using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {

        public List<Product> GetProductsWithCategory()
        {
            using var context = new Context();

            return context.Products.Include(x => x.Category).ToList();
        }

        public List<Product> GetAllPizza()
        {
            using var context = new Context();

            return context.Products.Where(p => p.Category.CategoryName == "Pizza").ToList();
        }

        public Product GetCheapestPizza()
        {
            using var context = new Context();

            return context.Products.Where(p=>p.Category.CategoryName == "Pizza").OrderBy(p=>p.ProductPrice).FirstOrDefault();
        }
    }
}