// Relação De Associação

Paciente p1 = new Paciente("Juan");
Medico m1 = new Medico("Dr.Daniel");

// Relação De Agregação

Universidade universidade = new Universidade();
Aluno aluno1 = new Aluno("Pablo");

Console.WriteLine($"Relação de Agregação: ");
//Da para fazer assim tambem:
//Mas, assim, voce tera que criar uma instancia para cada aluno.
universidade.AdicionarAluno(aluno1);

universidade.AdicionarAluno(new Aluno("Juan"));
universidade.AdicionarAluno(new Aluno("Pedro"));
universidade.MostrarAluno();

// Relaçao de Composição

Casa c1 = new Casa();
Console.WriteLine($"Relação de Composição: ");
c1.AdicionarComodo(new Comodo("Sala"));
c1.AdicionarComodo(new Comodo("Cozinha"));
c1.AdicionarComodo(new Comodo("Quarto"));
c1.MostrarComodos();
