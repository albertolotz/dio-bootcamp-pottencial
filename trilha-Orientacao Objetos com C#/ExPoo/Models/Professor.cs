using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExPoo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, meu salario é {Salario} .");
        }
    }
}