using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using FluentValidation;

namespace Doc.CL02Manager.Validator
{
    public class NovoEnderecoValidator : AbstractValidator<NovoEndereco>
    {
        public NovoEnderecoValidator()
        {
            RuleFor(p => p.Cidade).NotEmpty().NotNull().MaximumLength(120);
            RuleFor(p => p.Cep).NotEmpty().NotNull().MaximumLength(8);
            RuleFor(p => p.Estado).NotEmpty().NotNull().MaximumLength(2).Matches("[A-Z]{2}");
            RuleFor(p => p.Logradouro).NotEmpty().NotNull().MaximumLength(250);
        }
    }
}
