using CommonClasses.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int contador=0;contador < listaString.Count ;contador++)
 {
  Console.WriteLine(listaString[contador]);
 }

foreach(string valor in listaString)
{
    Console.WriteLine(valor);
}

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 1;
// arrayInteiros[1] = 40;
// arrayInteiros[2] = 71;
// arrayInteiros[3] = 72;

// int[] arrayNovo = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros, arrayNovo,arrayInteiros.Length);


//  //Array.Resize(ref arrayInteiros, arrayInteiros.Length*2);


//  for(int contador=0;contador < arrayInteiros.Length;contador++)
//  {
//   Console.WriteLine("Array Inteiros:" + arrayInteiros[contador]);
//  }
 
//  for(int contador=0;contador < arrayNovo.Length;contador++)
//  {
//   Console.WriteLine("Array Novo:" + arrayNovo[contador]);
//  }

//foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }


// Calculadora cal = new Calculadora();
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Alberto";
// pessoa1.Idade=33;
// pessoa1.NomeRepresentanteLegal="papa";

// pessoa1.Apresentar();

// cal.Somar(1,5);

// int a = 20;
// int b = 10;

// int c = a+b;

// //c=c+5;
// //c+=5;
// c-=5;

//Console.WriteLine(c);
//
//int a = Convert.ToInt32("5");
//int b = int.Parse("7");
//string d = Convert.ToString(4);
//
//Console.WriteLine(a);
//Console.WriteLine(b);

//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

//int a = 5;
//double b = a;
//long c = a;
//
//Console.WriteLine(b);

//double a = 4/2+2;
// double a = 4/(2+2);

// Console.WriteLine(a);

//string a = "15.";
//int b = 0;
//
//int.TryParse(a, out b);
//Console.WriteLine(b);
//Console.WriteLine("convertido");

// int estoqueCelular = 10;
// int compra = 0;
// bool podeVender = compra > 0 && estoqueCelular>=compra; 

// if(compra==0)
// {
//     Console.WriteLine("compra não pode ser 0");
// } else if (podeVender)
// {
//     Console.WriteLine("vendeu");
// }
// else
// {
//     Console.WriteLine("Estoque não disponivel");
// }

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();
//
//switch(letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//    Console.WriteLine("vogal");
//    break;
//    
//    default:
//    Console.WriteLine("não é vogal");
//    break;
//}
//

//int numero = 5;
 //int limite = 10;
 //int contador = 0;
// for(int contador = 0;contador <= limite;contador ++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// while(contador <= limite)
// {
//  Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//  contador++;
//  if(contador == 6) break;
// }

// int soma=0, numero=0;

// do
// {
//     Console.WriteLine("Digite um numero:");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
//     Console.WriteLine($"Soma: {soma}");
// } while(numero != 0);

// string opcao;
// bool menuAtivo = true;

// while(menuAtivo)
// {
//     Console.WriteLine("Selecione uma opção:");
//     Console.WriteLine("1-Cadastro Cliente");
//     Console.WriteLine("2-Cadastro Fornecedor");
//     Console.WriteLine("3-Fazer uma Venda");
//     Console.WriteLine("4-Consultar Vendas do dia");
//     Console.WriteLine("99-Sair deste menu");

//     opcao = Console.ReadLine();
   
//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrando Cliente");
//         break;
//         case "2":
//             Console.WriteLine("Cadastrando Fornecedor.");
//         break;
//         case "3":
//             Console.WriteLine("Fazendo uma venda.");
//         break;
//         case "4":
//             Console.WriteLine("Consultando vendas do dia.");
//         break;
//         case "99":
//             menuAtivo = false;
//         break;
//         default:
//             Console.WriteLine("Opção inválida, tente novamente");
//         break;
//     }
//     Console.Clear();
//     Console.WriteLine("Programa finalizado");
// }