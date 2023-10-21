using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karekter girişi yapın");
            RuleFor(x=>x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz").EmailAddress().WithMessage("Geçerli email adresi giriniz");
            //RuleFor(x=>x.SenderMail).NotEmpty().WithMessage("Adresi boş geçemezsiniz").EmailAddress().WithMessage("Geçerli email adresi giriniz");
        }
    }
}
