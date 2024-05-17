class Program
{
    static void Main(string[] args)
    {
        Playlist minhaPlaylist = new Playlist("Eu");

        // Adicionando algumas músicas à playlist
        minhaPlaylist.AdicionarMúsica(new Música("Shape of You", "Ed Sheeran", "Atlantic Records"));
        minhaPlaylist.AdicionarMúsica(new Música("Bohemian Rhapsody", "Queen", "EMI Records"));
        minhaPlaylist.AdicionarMúsica(new Música("Rolling in the Deep", "Adele", "XL Recordings"));

        // Tocando uma música aleatória
        minhaPlaylist.TocarMúsicaAleatória();
    }
}