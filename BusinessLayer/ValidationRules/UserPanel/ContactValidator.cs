using EntityLayer.Concreate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.UserPanel
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("Lütfen isminizi giriniz.");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Lütfen mail dresinizi giriniz.");
            RuleFor(x => x.ContactComment).NotEmpty().WithMessage("Lütfen mesajınızı giriniz.");

        }
    }
}
