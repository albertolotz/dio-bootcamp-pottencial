using ExExplorando.Models;

Pessoa p1 = new Pessoa(nome:"alberto", sobrenome:"lotz");
Pessoa p2 = new Pessoa(nome:"Paulo", sobrenome:"Santos");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles Baciso";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();
Console.WriteLine(cursoDeIngles.ObterQuantidadeDeAlunosMatriculados());
cursoDeIngles.RemoverAluno(p1);

cursoDeIngles.ListarAlunos();
Console.WriteLine(cursoDeIngles.ObterQuantidadeDeAlunosMatriculados());




