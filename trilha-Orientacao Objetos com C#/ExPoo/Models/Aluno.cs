using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExPoo.Models
{
    public class Aluno : Pessoa // herança
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {
            
        }
        
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, minha nota é {Nota}");
        }
    }
}