using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doc.CL04Core.CLCoreShared.ModelViewls
{
    /// <summary>
    /// Objeto utilizado para editar cliente.
    /// </summary>
    public class AlteraCliente : NovoCliente
    {
        /// <summary>
        /// ID do Cliente
        /// </summary>
        /// <Example>999</Example>
        public int Id { get; set; }
    }
}