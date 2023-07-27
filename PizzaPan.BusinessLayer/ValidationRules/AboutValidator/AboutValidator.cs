using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.ValidationRules.AboutValidator
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x=>x.Title).MinimumLength(3).WithMessage("Başlık alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x=>x.Title).MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakterden oluşmalıdır");

            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt Başlık alanı boş geçilemez");
            RuleFor(x => x.SubTitle).MinimumLength(3).WithMessage("Alt Başlık alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.SubTitle).MaximumLength(200).WithMessage("Alt Başlık alanı en fazla 200 karakterden oluşmalıdır");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("Açıklama alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Açıklama alanı en fazla 500 karakterden oluşmalıdır");

            RuleFor(x => x.Field1Text).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Field1Text).MinimumLength(3).WithMessage("Açıklama alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Field1Text).MaximumLength(100).WithMessage("Açıklama alanı en fazla 100 karakterden oluşmalıdır");
            RuleFor(x => x.Field1ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");

            RuleFor(x => x.Field2Text).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Field2Text).MinimumLength(3).WithMessage("Açıklama alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Field2Text).MaximumLength(100).WithMessage("Açıklama alanı en fazla 100 karakterden oluşmalıdır");
            RuleFor(x => x.Field2ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");

            RuleFor(x => x.Field3Text).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Field3Text).MinimumLength(3).WithMessage("Açıklama alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Field3Text).MaximumLength(100).WithMessage("Açıklama alanı en fazla 100 karakterden oluşmalıdır");
            RuleFor(x => x.Field3ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");

            RuleFor(x => x.Field4Text).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Field4Text).MinimumLength(3).WithMessage("Açıklama alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Field4Text).MaximumLength(100).WithMessage("Açıklama alanı en fazla 100 karakterden oluşmalıdır");
            RuleFor(x => x.Field4ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");
        }
    }
}