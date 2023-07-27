using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.ValidationRules.CategoryValidator
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori isim alanı boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori isim alanı minimum 3 karakter olmalıdır");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori isim alanı maksimum 50 karakter olmalıdır");
        }
    }
}