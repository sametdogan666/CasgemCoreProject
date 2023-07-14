using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetContactSubjectWithThx()
        {
            return _contactDal.GetContactSubjectWithThx();
        }
    }
}