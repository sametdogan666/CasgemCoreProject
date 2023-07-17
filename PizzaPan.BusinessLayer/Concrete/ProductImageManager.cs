using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void TInsert(ProductImage entity)
        {
            _productImageDal.Insert(entity);
        }

        public void TUpdate(ProductImage entity)
        {
            _productImageDal.Update(entity);
        }

        public void TDelete(ProductImage entity)
        {
            _productImageDal.Delete(entity);
        }

        public List<ProductImage> TGetList()
        {
            return _productImageDal.GetList();
        }

        public ProductImage TGetById(int id)
        {
            return _productImageDal.GetById(id);
        }
    }
}