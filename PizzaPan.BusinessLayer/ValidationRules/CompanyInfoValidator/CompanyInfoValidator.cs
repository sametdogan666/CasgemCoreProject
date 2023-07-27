using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.ValidationRules.CompanyInfoValidator
{
    public class CompanyInfoValidator : AbstractValidator<CompanyInfo>
    {
        public CompanyInfoValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x=>x.Title).MinimumLength(3).WithMessage("Başlık alanı en az 3 karakter olmalıdır");
            RuleFor(x=>x.Title).MaximumLength(3).WithMessage("Başlık alanı en fazla 50 karakter olmalıdır");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası alanı boş geçilemez");
            RuleFor(x => x.PhoneNumber).MinimumLength(3).WithMessage("Telefon numarası alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.PhoneNumber).MaximumLength(20).WithMessage("Telefon numarası alanı en fazla 50 karakter olmalıdır");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Mail).MinimumLength(3).WithMessage("Mail alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.Mail).MaximumLength(50).WithMessage("Mail alanı en fazla 50 karakter olmalıdır");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail alanı mail formatında olmalıdır");

            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres alanı boş geçilemez");
            RuleFor(x => x.Address).MinimumLength(3).WithMessage("Adres alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.Address).MaximumLength(100).WithMessage("Adres alanı en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Location).NotEmpty().WithMessage("Lokasyon alanı boş geçilemez");
            RuleFor(x => x.Location).MinimumLength(3).WithMessage("Lokasyon alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.Location).MaximumLength(500).WithMessage("Lokasyon alanı en fazla 500 karakter olmalıdır");

        }
    }
}