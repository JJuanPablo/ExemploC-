class Casa
{
    private List<Comodo> comodos = new List<Comodo>();

    public void AdicionarComodo(Comodo comodo)
    {
        comodos.Add(comodo);
    }

    public void MostrarComodos()
    {
        foreach (Comodo comodo in comodos)
        {
            Console.WriteLine($"Comodo: {comodo.Nome}");
        }
    }
}
