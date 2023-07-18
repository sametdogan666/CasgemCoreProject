using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.ValidationRules.OurTeamValidator
{
    public class CreateOurTeamValidator : AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.FirstName).MinimumLength(3).WithMessage("İsim alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("İsim alanı en fazla 50 karakterden oluşmalıdır");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim alanı boş geçilemez");
            RuleFor(x => x.LastName).MinimumLength(3).WithMessage("Soyisim alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.LastName).MaximumLength(50).WithMessage("Soyisim alanı en fazla 50 karakterden oluşmalıdır");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık alanı en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık alanı en fazla 50 karakterden oluşmalıdır");
        }
    }
}