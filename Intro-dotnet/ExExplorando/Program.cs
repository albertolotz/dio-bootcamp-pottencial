
using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
        Dictionary<int, int> frequencia = new Dictionary<int, int>();

        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < num.Count() ;i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        var dictSource = nums.ToLookup(x => x);
        foreach(IGrouping<int,int> n in dictSource){
            System.Console.WriteLine(n.Key);
        }
        //var numberOfModes = dictSource.Max(x => x.Count());
        //var modes = dictSource.Where(x => x.Count() == numberOfModes).Select(x => x.Key);

        
        return   0 ;
    }
}


// using ExExplorando.Models;
// using System.Globalization;
// using Newtonsoft.Json;


// using System;
// using System.Text.RegularExpressions;

// public class Program
// {
//     public static void Main(String[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
        
//         int[] num = new int[n];

//         // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < n ;i++)
//         {
//             num[i] = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine(MajorityElement(num));
        
//     }
//     public static int MajorityElement(int[] nums)
//     {
//         int major = nums[0];
//         int count = 1;
//         for (int i = 0; i < count; i++)
//         {
//             if (major == nums[i] )
//             {
//                 major = nums[i];
//                 count++;
//             }
//             else
//             {
//                 if (major == nums[i])
//                 {
//                     count++;
//                 }
//                 else
//                 {
//                     count--;
//                 }
//             }
//         }
//         return nums[0];
//     }
// }

// int numero = 21;
// bool par = false;

// par = numero.EhPar();

// string mensagem = (par ? "par" : "impar");

// System.Console.WriteLine(mensagem);




// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicinarElementoArray(2);

// Console.WriteLine(arrayInteiro[0]);

//dynamic variavelDinamica = "4";

//System.Console.WriteLine(variavelDinamica.GetType() + " " + variavelDinamica);



//string conteudoFile = File.ReadAllText("Arquivos/vendas.json");
//List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoFile);
//
//var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });
//
//foreach(var venda in listaAnonimo)
//{
//    //Console.WriteLine($"Id:{venda.Id} , Produto:{venda.Produto} , Preço:{venda.Preco} , Data:{venda.DataVenda}, Desconto: {(venda.Desconto.HasValue? venda.Desconto : "Null")}");
//    Console.WriteLine($"Produto:{venda.Produto} , Preço:{venda.Preco}");
//}



//var tipoAnomimo = new { Nome = "Alberto", SobreNome = "Lotz", Altura = 2 };
//
//System.Console.WriteLine(tipoAnomimo.Nome);





//bool? desejaReceberEmail = null;

//if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// if(desejaReceberEmail != null && desejaReceberEmail.Value)
// {
//     System.Console.WriteLine("Recebe Email");
// }
// else
// {
//     System.Console.WriteLine("Não Recebe");
// }
































// LeituraFile arquivo = new LeituraFile();

// List<Venda> listaVendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Bola", 33.00M,dataAtual);
// Venda v2 = new Venda(2, "taco", 13.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// System.Console.WriteLine(serializado);

// File.WriteAllText("Arquivos/vendas.json", serializado);







//int numero = 21;
// bool ePar = false;

// ePar = numero % 2 == 0;

// Console.WriteLine(ePar? "par" : "impar");








// Pessoa p1 = new Pessoa("Alberto", "Lotz");

// (string nome, string sobrenome) = p1;

// System.Console.WriteLine(nome + " " + sobrenome);







//var(sucesso, linhasArquivo, quantidadeLinhas)= arquivo.LerArquivo("zArquivos/arquivoLeitura.txt");
// _ = descarte
// var(sucesso, linhasArquivo, _)= arquivo.LerArquivo("zArquivos/arquivoLeitura.txt");
// if(sucesso)
// {
//     //Console.WriteLine("Qtd Linhas: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     System.Console.WriteLine("não foi possivel ver o arquivo.");
// }

//
////mais indicado para legibilidade do codigo.
//(int, string, string,decimal) tupla = (1, "Alberto", "lotz",10.04M);
//
//System.Console.WriteLine($"Codigo: {tupla.Item1}");
//System.Console.WriteLine($"None: {tupla.Item2}");
//System.Console.WriteLine($"Sobre Nome: {tupla.Item3}");
//System.Console.WriteLine($"Salario: {tupla.Item4}");
//
//ValueTuple<int, string, string, decimal> outroExTupla = (1, "Alberto", "lotz",10.04M);
//
//System.Console.WriteLine($"Codigo: {outroExTupla.Item1}");
//System.Console.WriteLine($"None: {outroExTupla.Item2}");
//System.Console.WriteLine($"Sobre Nome: {outroExTupla.Item3}");
//System.Console.WriteLine($"Salario: {outroExTupla.Item4}");
//
//var tupla3 = Tuple.Create(1, "Alberto", "lotz",10.04M);
//
//System.Console.WriteLine($"Codigo: {tupla3.Item1}");
//System.Console.WriteLine($"None: {tupla3.Item2}");
//System.Console.WriteLine($"Sobre Nome: {tupla3.Item3}");
//System.Console.WriteLine($"Salario: {tupla3.Item4}");
//
//





//new ExExcessao().Metodo1();





// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine("arquivo nao encontrado "+ ex.Message);
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine("pasta não encontrada "+ ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Erro inesperado "+ ex.Message);
// }
// finally
// {
//     System.Console.WriteLine("final");
// }











// string dataStr = "2022-13-17 18:00";
// DateTime.TryParseExact(dataStr, "yy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// Console.WriteLine(data.ToLongDateString());





// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40m;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// double porcentagem = .4355;

// Console.WriteLine(porcentagem.ToString("P0"));





//Pessoa p1 = new Pessoa(nome:"alberto", sobrenome:"lotz");
//Pessoa p2 = new Pessoa(nome:"Paulo", sobrenome:"Santos");
//
//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles Baciso";
//cursoDeIngles.Alunos = new List<Pessoa>();
//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//
//cursoDeIngles.ListarAlunos();
//Console.WriteLine(cursoDeIngles.ObterQuantidadeDeAlunosMatriculados());
//cursoDeIngles.RemoverAluno(p1);
//
//cursoDeIngles.ListarAlunos();
//Console.WriteLine(cursoDeIngles.ObterQuantidadeDeAlunosMatriculados());



