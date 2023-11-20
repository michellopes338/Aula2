class Album
{
    List<Musica> musicas = new();
    public string Nome { get; }

    public Album(string nome)
    {
        Nome = nome;
    }

    public int Duracao 
    {
        get
        {
            return musicas.Sum(cadaMusica => cadaMusica.duracao);
        }
    }
    public void AdicionaMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void DescreveAlbum()
    {
        System.Console.WriteLine($"Album: {Nome}\n");
        
        foreach(Musica musica in musicas)
        {
            System.Console.WriteLine($"Nome: {musica.DescricaoResumida}");
            System.Console.WriteLine($"Genero: {musica.Genero}");
            System.Console.WriteLine();
        }

        System.Console.WriteLine($"\nDuração: {Duracao} segundos");
    }
}