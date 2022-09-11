using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonClasses.Common.Models
{
    /// <summary>
    /// Definição de uma pessoa
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? NomeRepresentanteLegal { get; set; }
        /// <summary>
        /// Pessoa se apresenta com dados pessoaos
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos. Meu representante legal é {NomeRepresentanteLegal}");
        }
    }
}