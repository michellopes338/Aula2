class Episodio
{
    public int Duracao { get; }
    public string Titulo { get; set; }
    List<string> convidados = new();
    public string Resumo
    {
        get
        {
            string convidadosString = string.Join(", ", convidados);
            return $"{Titulo} ft ({convidadosString})";
        }
    }
    public Episodio(int duracao, string titulo)
    {
        Duracao = duracao;
        Titulo = titulo;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}