class Musica
{
    public Musica(string nome, Banda artista, int duracao, bool disponivel, Genero genero)
    {
        this.nome = nome;
        this.artista = artista;
        this.duracao = duracao;
        Disponivel = disponivel;
        Genero = genero;
    }
    public string nome;
    public Banda artista;
    public int duracao;
    public bool Disponivel {get;}

    public Genero Genero { get; set; }

    public string DescricaoResumida
    { 
        get
        {
            return $"{nome} - {artista}";
        }
    }
}