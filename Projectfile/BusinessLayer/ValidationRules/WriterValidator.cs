using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator() 
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad Soyad yazin!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Email  yazin!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre yazin!");
            RuleFor(x => x.WriterName).Length(3,20).WithMessage("Isim 3 den küçük 20den büyük olamaz!");
        }

        
    }
}
