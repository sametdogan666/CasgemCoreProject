using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.ValidationRules.BlockValidator
{
    public class BlockValidator:AbstractValidator<Block>
    {
        public BlockValidator()
        {
            RuleFor(x => x.Title1).NotEmpty().WithMessage("Başlık 1 alanı boş geçilemez");
            RuleFor(x => x.Title1).MinimumLength(3).WithMessage("Başlık 1 alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Title1).MaximumLength(50).WithMessage("Başlık 1 alanı en fazla 50 karakterden oluşmalıdır");

            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 alanı boş geçilemez");
            RuleFor(x => x.Description1).MinimumLength(3).WithMessage("Açıklama 1 alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Description1).MaximumLength(250).WithMessage("Açıklama 1 alanı en fazla 250 karakterden oluşmalıdır");

            RuleFor(x => x.Title2).NotEmpty().WithMessage("Başlık 2 alanı boş geçilemez");
            RuleFor(x => x.Title2).MinimumLength(3).WithMessage("Başlık 2 alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Title2).MaximumLength(50).WithMessage("Başlık 2 alanı en fazla 50 karakterden oluşmalıdır");

            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 alanı boş geçilemez");
            RuleFor(x => x.Description2).MinimumLength(3).WithMessage("Açıklama 2 alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Description2).MaximumLength(250).WithMessage("Açıklama 2 alanı en fazla 250 karakterden oluşmalıdır");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");
        }
    }
}