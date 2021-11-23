using EntityLayer.Concreate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AdminPanel
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminName).NotEmpty().WithMessage("Lütfen admin adını giriniz.");
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Lütfen şifreyi giriniz.");
            RuleFor(x => x.AdminPassword).MinimumLength(6).WithMessage("Şifre en az 6 karakterden oluşmalıdır.");
        }
    }
}
