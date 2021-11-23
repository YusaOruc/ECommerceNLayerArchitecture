using EntityLayer.Concreate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.UserPanel
{
    public class RegisterValidator : AbstractValidator<User>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz.");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresinizi boş geçemezsiniz.");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Şifrenizi boş geçemezsiniz.");
            RuleFor(x => x.UserNumber).NotEmpty().WithMessage("Telefon numaranızı boş geçemezsiniz.");
            RuleFor(x => x.UserPassword).MinimumLength(6).WithMessage("Şifreniz en az 6 karakter olmalıdır.");
            
        }
    }
}
