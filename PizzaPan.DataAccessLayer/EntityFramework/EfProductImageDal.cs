using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfProductImageDal : GenericRepository<ProductImage>, IProductImageDal
    {

    }
}