using FluentValidation;
using ProjectBlogNew.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNew.BusinessLayer.ValidationRules
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.ArticleTitle).NotEmpty().WithMessage("Makale başlığını boş geçemezsiniz");
            RuleFor(x => x.ArticleContent).NotEmpty().WithMessage("Makale içeriğini boş geçemezsiniz");
            RuleFor(x => x.ArticleCImage).NotEmpty().WithMessage("Resim içeriğini boş geçemezsiniz");
            RuleFor(x => x.ArticleTitle).MaximumLength(150).WithMessage("150 karakterden az veri girişi yapın");
            RuleFor(x => x.ArticleTitle).MinimumLength(5).WithMessage("150 karakterden fazla veri girişi yapın");

        }
    }
}
