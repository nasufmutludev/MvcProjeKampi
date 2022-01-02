using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterMail).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.About).MaximumLength(20).WithMessage("Hakkımda kısmını boş geçemezsiniz");
        }
    }

}
