using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçmeyin! ");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriyini boş geçmeyin! ");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog fotarafını boş geçmeyin! ");
            RuleFor(x => x.BlogTitle).Length(5,50).WithMessage("Blog başlığını 4 karakterden aşağı 50 karakterden yukarı geçmeyin! ");
            //RuleFor(x => x.BlogTitle).NotEqual(x=>x.BlogTitle).WithMessage("Bu isimde bir blog var. Yni bir isim giriniz.");
        }
    }
}
