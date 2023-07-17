using Microsoft.AspNetCore.Identity;

namespace PizzaPan.PresentationLayer.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"En az {length} karakter girişi yapınız"
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError()
            {
                Code = "PasswordMismatch",
                Description = "Şifreler eşleşmiyor"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parolalar en az bir küçük harfe ('a'-'z') sahip olmalıdır."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parolalarda en az bir büyük harf ('A'-'Z') bulunmalıdır."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Parolalar en az bir rakamdan ('0'-'9') oluşmalıdır."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parolalar en az bir sembol içermelidir."
            };
        }

    }
}