using BusinessLayer.Concreate;
//using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   
   public class CategoryValidator : AbstractValidator<Category>
    {
       
       
        public CategoryValidator()
        {
            //RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Katqoriya adını daxil edin! ");
            //RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Katqoriya detaylarını daxil edin! ");
            //RuleFor(x => x.CategoryName).Length(5, 50).WithMessage("Katqoriya adnını 4 hərfdən aşağı 50 hərfdən yuxarı yazmayın! ");
            //RuleFor(x => x.CategoryName).Matches(CategoryName).WithMessage("Bu adda bir Katqoriya var. Yeni bir ad daxil edin!");
        }
    }
}
