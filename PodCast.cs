class PodCast
{
    public string Host { get; }
    public string Nome { get; }
    List<Episodio> episodios = new();
    public int TotalEpisodios
    { 
        get
        {
            return episodios.Count;
        }
    }
    public PodCast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"O podcast {Nome} é apresentado pelo host {Host}");
        episodios.ForEach(cadaEpisodio => System.Console.WriteLine(cadaEpisodio.Resumo));
    }
}