using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }
    }
}