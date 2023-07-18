using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TInsert(OurTeam entity)
        {
            _ourTeamDal.Insert(entity);
        }

        public void TUpdate(OurTeam entity)
        {
            _ourTeamDal.Update(entity);
        }

        public void TDelete(OurTeam entity)
        {
            _ourTeamDal.Delete(entity);
        }

        public List<OurTeam> TGetList()
        {
            return _ourTeamDal.GetList();
        }

        public OurTeam TGetById(int id)
        {
            return _ourTeamDal.GetById(id);
        }
    }
}