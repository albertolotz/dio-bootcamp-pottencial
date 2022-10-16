using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Doc.CL04Core.CLCoreShared.ModelViewls;

namespace Doc.CL02Manager.Interfaces
{
    public interface IClienteManager
    {
        Task<IEnumerable<Cliente>> GetClientesAsync();

        Task<Cliente> GetClientesAsync(int id);

         Task<Cliente> InsertClienteAsync(NovoCliente cliente);

        Task<Cliente> UpdateClienteAsync(AlteraCliente cliente);
        
        Task DeleteClienteAsync(int id);

    }
}