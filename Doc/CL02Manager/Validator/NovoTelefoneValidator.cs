using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using FluentValidation;

namespace Doc.CL02Manager.Validator
{
    public class NovoTelefoneValidator : AbstractValidator<NovoTelefone>
    {
       public NovoTelefoneValidator()
       {
         RuleFor(x => x.Numero).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("Formato esperado: [2-9][0-9]{10}");
       }
    }
}