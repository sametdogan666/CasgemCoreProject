using System;
using System.Collections.Generic;
using System.Text;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TInsert(Discount entity)
        {
            entity.DiscountCode = GenerateRandomString();
            _discountDal.Insert(entity);
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public List<Discount> TGetList()
        {
            return _discountDal.GetList();
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        private string GenerateRandomString()
        {
            Random random = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                int randomIndex = random.Next(letters.Length);
                builder.Append(letters[randomIndex]);
            }

            for (int i = 0; i < 2; i++)
            {
                int randomIndex = random.Next(digits.Length);
                builder.Append(digits[randomIndex]);
            }

            return builder.ToString();
        }
    }
}