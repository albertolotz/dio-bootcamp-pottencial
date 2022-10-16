using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using AutoMapper;

namespace Doc.CL02Manager.Mapping
{
    public class AlteraClienteMappingProfile : Profile
    {
        public AlteraClienteMappingProfile()
        {
          CreateMap<AlteraCliente, Cliente>()
                .ForMember(destino => destino.UltimaAtualizacao, origem => origem.MapFrom(valor => DateTime.Now))
                .ForMember(destino => destino.DataNascimento, origem => origem.MapFrom(valor => valor.DataNascimento.Date));  
        }
    }
}