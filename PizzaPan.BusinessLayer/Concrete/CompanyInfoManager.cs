using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class CompanyInfoManager : ICompanyInfoService
    {
        private readonly ICompanyInfoDal _companyInfoDal;

        public CompanyInfoManager(ICompanyInfoDal companyInfoDal)
        {
            _companyInfoDal = companyInfoDal;
        }

        public void TInsert(CompanyInfo entity)
        {
            _companyInfoDal.Insert(entity);
        }

        public void TUpdate(CompanyInfo entity)
        {
            _companyInfoDal.Update(entity);
        }

        public void TDelete(CompanyInfo entity)
        {
            _companyInfoDal.Delete(entity);
        }

        public List<CompanyInfo> TGetList()
        {
            return _companyInfoDal.GetList();
        }

        public CompanyInfo TGetById(int id)
        {
            return _companyInfoDal.GetById(id);
        }
    }
}