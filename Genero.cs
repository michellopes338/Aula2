class Genero
{
    public Genero(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }

    public override string ToString()
    {
        return Nome;
    }
}