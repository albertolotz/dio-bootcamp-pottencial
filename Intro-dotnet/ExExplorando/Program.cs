using ExExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "SAO PAULO");
estados.Add("RJ", "RIO DE JANEIRO");
estados.Add("AC", "ACRE");
 //foreach(KeyValuePair<string, string> item in estados)
 foreach(var item in estados)
 {
     System.Console.WriteLine(item.Key + " " + item.Value);
 }

estados.Remove("SP");

foreach(var item in estados)
 {
     System.Console.WriteLine(item.Key + " " + item.Value);
 }

// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);

// foreach(int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// pilha.Pop();

// foreach(int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);
// fila.Enqueue(6);
// fila.Enqueue(7);
// fila.Enqueue(8);

// foreach( int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// fila.Dequeue();

// foreach( int item in fila)
// {
//     System.Console.WriteLine(item);
// }





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



