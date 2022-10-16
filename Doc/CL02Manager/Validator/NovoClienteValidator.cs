using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using FluentValidation;

namespace Doc.CL02Manager.Validator
{
    public class NovoClienteValidator : AbstractValidator<NovoCliente>
    {
        public NovoClienteValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(3).MaximumLength(100).WithMessage("Esperado nome não vazio, 3 letras no mínimo e 100 no máximo.");
            RuleFor(x => x.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.Documento).NotNull().NotEmpty().MinimumLength(4).MaximumLength(14);
            RuleFor(x => x.Telefone).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("Formato esperado: [2-9][0-9]{10}");
            RuleFor(x => x.Sexo).NotNull().NotEmpty().Must(IsMorF).WithMessage("Opções validas para Sexo: F , M ou I");
        }

        private bool IsMorF(string sexo)
        {
            return sexo == "M" || sexo == "F" || sexo == "I";
        }
    }
}