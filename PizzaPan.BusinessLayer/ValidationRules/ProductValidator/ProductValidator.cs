using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.ValidationRules.ProductValidator
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün ismi boş geçilemez");
            RuleFor(x=>x.ProductName).MinimumLength(3).WithMessage("Ürün ismi en az 3 karakterden oluşmalıdır");
            RuleFor(x=>x.ProductName).MaximumLength(50).WithMessage("Ürün ismi en fazla 50 karakterden oluşmalıdır");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez");
            RuleFor(x => x.ProductDescription).MinimumLength(3).WithMessage("Ürün açıklaması en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.ProductDescription).MaximumLength(500).WithMessage("Ürün açıklaması en fazla 500 karakterden oluşmalıdır");

            RuleFor(x => x.ProductImageUrl).NotEmpty().WithMessage("Ürün resmi boş geçilemez");

            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");
            RuleFor(x => x.ProductPrice).GreaterThanOrEqualTo(0).WithMessage("Ürün fiyatı 0'dan büyük veya eşit olmalıdır");

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori alanı boş geçilemez");
        }
    }
}