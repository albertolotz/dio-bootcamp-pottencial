

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

string opcao;
bool menuAtivo = true;

while(menuAtivo)
{
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1-Cadastro Cliente");
    Console.WriteLine("2-Cadastro Fornecedor");
    Console.WriteLine("3-Fazer uma Venda");
    Console.WriteLine("4-Consultar Vendas do dia");
    Console.WriteLine("99-Sair deste menu");

    opcao = Console.ReadLine();
   
    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastrando Cliente");
        break;
        case "2":
            Console.WriteLine("Cadastrando Fornecedor.");
        break;
        case "3":
            Console.WriteLine("Fazendo uma venda.");
        break;
        case "4":
            Console.WriteLine("Consultando vendas do dia.");
        break;
        case "99":
            menuAtivo = false;
        break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
        break;
    }
    Console.Clear();
    Console.WriteLine("Programa finalizado");
}