using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>//Doğrulama işlemi.. katergori sınıfı üzürinde çalıştığımız için T değeri olarak Kategori sınıfını çağırdık..
    {
        public CategoryValidator()//Bu kısımda kural tanımlamaları yapıcazz..
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz..!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçezemezsiniz..!");
            //NotEmpty: Boş geçilemez anlamına gelir. Yani; kategori ismi mutlaka yazxılmalıdır..
            //WithMessage: Kullanıcıcay  mesaj kısmıdır; Türkçe harf kullanılabilir...
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın..!");//MinimumLenght: Minumum Karakter uzunluğpunu belirtiyor.
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapın..!");//MaximumLenght: Maximum Karakter uzunluğunu belirtiyor..
        }
    }
}
