class Medico
{
    public string Nome { get; set; }

    public Medico(string nome)
    {
        Nome = nome;
    }

    public void AtenderPaciente(Paciente paciente)
    {
        Console.WriteLine($"{Nome} está atendendo o paciente {paciente.Nome}");
    }



}