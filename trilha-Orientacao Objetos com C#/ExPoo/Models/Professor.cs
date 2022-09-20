using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExPoo.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        
        public  Professor(string nome) : base(nome)
        {
            
        }
        
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, meu salario é {Salario} .");
        }
    }
}