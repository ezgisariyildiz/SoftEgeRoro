using EgeRoro.Entity.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Validation
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama kısımı boş geçilemez...");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama kısımı boş geçilemez...");
            RuleFor(x => x.Description1).MinimumLength(20).WithMessage("En az 20 karakter girilmeli...");
            RuleFor(x => x.Description2).MinimumLength(20).WithMessage("En az 20 karakter girilmeli...");
            RuleFor(x => x.Description1).MaximumLength(1500).WithMessage("En fazla 1500 karakter girebilirsiniz...");
            RuleFor(x => x.Description2).MaximumLength(1500).WithMessage("En fazla 1500 karakter girebilirsiniz...");
        }
    }
}
