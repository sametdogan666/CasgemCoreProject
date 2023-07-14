using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetProductsWithCategoryList()
        {
            return _productDal.GetProductsWithCategory();
        }
    }
}