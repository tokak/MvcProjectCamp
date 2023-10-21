using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.About).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password kısmını boş geçemezsiniz");
            RuleFor(x => x.About).Must(x=>x.Contains("a")).WithMessage("Hakkında kısmında min 1 tane a harfi içermelidir ");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen en az 2 karekter girişi yapın");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen en az 2 karekter girişi yapın");
        }
    }
}
