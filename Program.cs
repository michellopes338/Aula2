Banda LiesOfP = new("Lies Of P");
Banda HollowKnight = new("Hollow Knight");
Banda Vivaldi = new("Vivaldi");

Genero games = new("Game Songs");
Genero classic = new("Classic");

Musica Feel = new("Feel", LiesOfP)
{
    duracao = 210,
    Disponivel = true,
    Genero = games
};
Musica EnterHallowNest = new("Enter HallowNest", HollowKnight)
{
    duracao = 312,
    Disponivel = true,
    Genero = games
};
Musica Winter = new("Winter", Vivaldi)
{
    duracao = 554,
    Disponivel = true,
    Genero = classic
};

Album album = new("Só as Melhores");

album.AdicionaMusica(Feel);
album.AdicionaMusica(EnterHallowNest);
album.AdicionaMusica(Winter);

album.DescreveAlbum();
