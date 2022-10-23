using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doc.CL04Core.CLCoreShared.ModelViewls
{
    /// <summary>
    /// Objeto utilizado para inserir novo cliente.
    /// </summary>
    public class NovoCliente
    {
        /// <summary>
        /// Nome Completo do Cliente
        /// </summary>
        /// <Example>Fulano de Tal</Example>
        public string Nome { get; set; }
        
        /// <summary>
        /// Data de Nascimento do Cliente
        /// </summary>
        /// <Example>2000-10-12</Example>
        public DateTime DataNascimento { get; set; }
        
        /// <summary>
        /// Sexo do Cliente F=Feminino, M=Masculino I=Indefinido
        /// </summary>
        /// <Example>F</Example>       
        public string Sexo { get; set; }

        /// <summary>
        /// Telefone principal do Cliente
        /// </summary>
        /// <Example>29999999999</Example>        
        public string Telefone { get; set; }
        
        /// <summary>
        /// Documento Identificação do Cliente CPF, CHN, RG
        /// </summary>
        /// <Example>9999999999</Example>
        public string Documento { get; set; }
    }
}