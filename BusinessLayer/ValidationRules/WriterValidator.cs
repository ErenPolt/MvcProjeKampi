using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public  class WriterValidator: AbstractValidator<Writer>//Doğrulama işlemi.. Writer sınıfı üzürinde çalıştığımız için T değeri olarak writer sınıfını çağırdık..
    {
        public WriterValidator()//Bu kısımda kural tanımlamaları yapıcazz..
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz..!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını Boş Geçezemezsiniz..!");
            //NotEmpty: Boş geçilemez anlamına gelir. Yani; yazar ismi mutlaka yazxılmalıdır..
            //WithMessage: Kullanıcıcay  mesaj kısmıdır; Türkçe harf kullanılabilir...
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar Hakkında Boş Geçezemezsiniz..!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvanını Boş Geçezemezsiniz..!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mail Kısmını Boş Geçezemezsiniz..!");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın..!");//MinimumLenght: Minumum Karakter uzunluğpunu belirtiyor.
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın..!");//MaximumLenght: Maximum Karakter uzunluğunu belirtiyor..
        }
    }
}
