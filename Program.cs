Banda LiesOfP = new("Lies Of P");
Banda HollowKnight = new("Hollow Knight");
Banda Vivaldi = new("Vivaldi");

Genero games = new("Game Songs");
Genero classic = new("Classic");

Musica Feel = new("Feel", LiesOfP, 210, true, games);
Musica EnterHallowNest = new("Enter HallowNest", HollowKnight, 312, true, games);
Musica Winter = new("Winter", Vivaldi, 554, true, classic);

Album album = new("Só as Melhores");

album.AdicionaMusica(Feel);
album.AdicionaMusica(EnterHallowNest);
album.AdicionaMusica(Winter);

album.DescreveAlbum();
