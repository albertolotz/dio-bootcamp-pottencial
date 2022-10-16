using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CL04Core.Domain;
using Doc.CL04Core.CLCoreShared.ModelViewls;

namespace Doc.CL02Manager.Mapping
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>()
                .ForMember(destino => destino.Criacao, origem => origem.MapFrom(valor => DateTime.Now))
                .ForMember(destino => destino.DataNascimento, origem => origem.MapFrom(valor => valor.DataNascimento.Date));
        }
    }
}