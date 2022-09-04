using System;
//using SintaxeTipoDados.Models;

string apresentacao = "Seja bem vindo";
int quantidade = 6;
double altura = 1.80;
decimal preco = 1.80m;
bool condicao = true;
decimal total = quantidade * preco;
DateTime dataVenda = DateTime.Now.AddDays(5).AddHours(2);
Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variavel preço: " + preco);
Console.WriteLine("Valor da variavel condição: " + condicao);
Console.WriteLine("Valor da variavel total: " + total);
Console.WriteLine("Valor da variavel data da venda: " + dataVenda.ToString("dd/MM/yyyy"));
Console.WriteLine("Valor da variavel hora da venda: " + dataVenda.ToString("HH:mm"));

//Pessoa pessoa1 = new Pessoa();
//
//pessoa1.Nome = "Alberto";
//pessoa1.Idade = 45;
//pessoa1.NomeRepresentanteLegal = "Helmuth";
//
//pessoa1.Apresentar();
//
//Pessoa pessoa2 = new Pessoa();
//
//pessoa2.Nome = "Paty";
//pessoa2.Idade = 42;
//pessoa2.NomeRepresentanteLegal="Alberto";
//
//pessoa2.Apresentar();

