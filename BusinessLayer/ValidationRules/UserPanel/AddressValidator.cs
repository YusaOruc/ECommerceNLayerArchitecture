using EntityLayer.Concreate.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.UserPanel
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.AddressHeader).NotEmpty().WithMessage("Adres başlığını boş geçemezsiniz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir adını boş geçemezsiniz.");
            RuleFor(x => x.AddressUser).NotEmpty().WithMessage("Açık adresi boş geçemezsiniz.");
            RuleFor(x => x.PostCode).NotEmpty().WithMessage("Posta kodunu boş geçemezsiniz.");
        }
    }
}
