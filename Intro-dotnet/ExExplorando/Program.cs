using ExExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

string conteudoFile = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoFile);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id:{venda.Id} , Produto:{venda.Produto} , Preço:{venda.Preco} , Data:{venda.DataVenda}");
}



















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



