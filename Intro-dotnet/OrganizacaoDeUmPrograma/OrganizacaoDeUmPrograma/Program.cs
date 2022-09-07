using CommonClasses.Common.Models;

Calculadora cal = new Calculadora();
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Alberto";
pessoa1.Idade=33;
pessoa1.NomeRepresentanteLegal="papa";

pessoa1.Apresentar();

cal.Somar(1,5);