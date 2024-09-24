class Universidade{

    private List<Aluno> alunos = new List<Aluno>();

    public void AdicionarAluno (Aluno aluno)
    {
        alunos.Add(aluno);
    }

    public void MostrarAluno(){
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"Aluno: {aluno.Nome}");
        }
    }
}