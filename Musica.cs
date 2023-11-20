class Musica
{
    public Musica(string nome, Banda artista)
    {
        this.nome = nome;
        this.artista = artista;
    }
    public string nome;
    public Banda artista;
    public int duracao;
    public bool Disponivel {get; set;}

    public Genero Genero { get; set; }

    public string DescricaoResumida
    { 
        get
        {
            return $"{nome} - {artista}";
        }
    }
}