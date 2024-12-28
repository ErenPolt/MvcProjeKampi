﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz..!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz..!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçezemezsiniz..!");
            //NotEmpty: Boş geçilemez anlamına gelir. Yani; kategori ismi mutlaka yazxılmalıdır..
            //WithMessage: Kullanıcıcay  mesaj kısmıdır; Türkçe harf kullanılabilir...
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın..!");//MinimumLenght: Minumum Karakter uzunluğpunu belirtiyor.
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın..!");//MinimumLenght: Minumum Karakter uzunluğpunu belirtiy
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen en fazla50 karakter girişi yapın..!");//MaximumLenght: Maximum Karakter uzunluğunu belirtiyor..
        }
    }
}
