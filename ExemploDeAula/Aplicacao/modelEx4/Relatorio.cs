class Relatorio : Imprimir{

    private string Nome;

    public Relatorio(string nome){
        Nome = nome;
    }

    public void Imprimir(){
        Console.WriteLine($"Imprimindo Relatório: " + Nome);
    }

}