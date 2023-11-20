class Banda
{
    public string Nome { get; }
    public List<Album> albuns = new();
    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionaAlbum(Album album)
    {
        albuns.Add(album);
    }

    public override string ToString()
    {
        return Nome;
    }
}