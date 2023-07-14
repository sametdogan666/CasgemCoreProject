using System.Collections.Generic;
using System.Linq;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetContactSubjectWithThx()
        {
            using var context = new Context();
            var values = context.Contacts.Where(x => x.ContactSubject == "Teşekkür").ToList();

            return values;
        }
    }
}