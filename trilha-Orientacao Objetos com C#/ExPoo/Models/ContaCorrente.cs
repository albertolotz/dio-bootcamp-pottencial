using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExPoo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        
        public int NumeroConta { get; set; }

        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if(Saldo>=valor)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque Realizado:");
            }
            else
            {
                System.Console.WriteLine("Saldo Insuficiente.");
            }
        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é {Saldo}");
        }

    }
}