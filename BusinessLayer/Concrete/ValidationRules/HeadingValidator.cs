﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Başlık Adını Boş Geçemezsiniz");
            RuleFor(x => x.HeadingName).MinimumLength(3).WithMessage("Lütfen en az 2 karekter girişi yapın");
        }
    }
}
