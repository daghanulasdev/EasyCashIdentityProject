using EasyCashIdentityProject.DTOLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad alani bos gecilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alani bos gecilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alani bos gecilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanici adi alani bos gecilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre alani bos gecilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Sifre tekrar alani bos gecilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lutfen en fazla 30 karakter girisi yapiniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lutfen en az 2 karakter girisi yapiniz");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eslesmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lutfen gecerli bir mail adresi giriniz");
        }
    }
}
