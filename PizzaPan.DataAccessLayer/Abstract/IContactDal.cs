using System.Collections.Generic;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.DataAccessLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        List<Contact> GetContactSubjectWithThx();
    }
}