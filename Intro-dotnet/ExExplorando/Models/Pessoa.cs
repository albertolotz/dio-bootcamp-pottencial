using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() // padrão que não recebe nada
        {

        }

        public Pessoa(string nome, string sobrenome) // isso é um construtor
        {
            Nome = nome;
            SobreNome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome 
        { 
         get => _nome.ToUpper();
         set
            {
                if(value =="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
         }

        public string SobreNome { get; set; }

        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

        public int Idade 
        {
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}