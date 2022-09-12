using ExExplorando.Models;
using System.Globalization;


string dataStr = "2022-13-17 18:00";
DateTime.TryParseExact(dataStr, "yy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
Console.WriteLine(data.ToLongDateString());





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



