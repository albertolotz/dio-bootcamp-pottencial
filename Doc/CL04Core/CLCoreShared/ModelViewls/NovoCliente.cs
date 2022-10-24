using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doc.CL04Core.CLCoreShared.ModelViewls
{
    
    public class NovoCliente
    {
       
        /// <summary>
        /// Nome do Cliente
        /// </summary>
        /// <example>Fulano de Tal</example> 
        public string Nome { get; set; }
        
        /// <summary>
        /// Data de Nascimento do Cliente
        /// </summary>
        /// <example>2000-10-12</example>
        public DateTime DataNascimento { get; set; }
        
        /// <summary>
        /// Sexo do Cliente F=Feminino, M=Masculino I=Indefinido
        /// </summary>
       /// <example>F</example>      
        public string Sexo { get; set; }

        /// <summary>
        /// Telefone principal do Cliente
        /// </summary>
        /// <example>29999999999</example>        
        public string Telefone { get; set; }
        
        /// <summary>
        /// Documento Identificação do Cliente CPF, CHN, RG
        /// </summary>
        /// <example>9999999999</example>
        public string Documento { get; set; }
        /// <summary>
        /// Endereço do Cliente.
        /// </summary>
        public NovoEndereco Endereco { get; set; }
    }
}