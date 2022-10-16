using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using FluentValidation;

namespace Doc.CL02Manager.Validator
{
    public class AlteraClienteValidator : AbstractValidator<AlteraCliente>
    {
        public AlteraClienteValidator()
        {
            RuleFor(fv => fv.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NovoClienteValidator()); // Traz os demais campos que já são validados para um novo cliente, tipo uma herança.
        }
    }
}