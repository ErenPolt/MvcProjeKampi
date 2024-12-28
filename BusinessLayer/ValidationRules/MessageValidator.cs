using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.Receiver).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz");
            //RuleFor(x => x.Receiver).Must(email => email.EndsWith("@gmail.com")).WithMessage("E-posta adresi yalnızca Gmail olmalıdır.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın..!");//MinimumLenght: Minumum Karakter uzunluğpunu belirtiy
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen en fazla50 karakter girişi yapın..!");//MaximumLenght: Maximum Karakter uzunluğunu belirtiyor..
        }
    }
}
