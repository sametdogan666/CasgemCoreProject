using System.Collections.Generic;

namespace PizzaPan.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetList();
        T TGetById(int id);
    }
}