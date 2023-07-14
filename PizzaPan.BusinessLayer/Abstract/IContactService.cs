using System.Collections.Generic;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        List<Contact> TGetContactSubjectWithThx();

    }
}