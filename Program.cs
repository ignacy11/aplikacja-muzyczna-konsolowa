public class Album(string bandName, string albumTitle, int tracks, int releaseYear, long downloads)
{
    public string BandName = bandName;
    public string AlbumTitle = albumTitle;
    public int Tracks = tracks;
    public int ReleaseYear = releaseYear;
    public long Downloads = downloads;

    public static List<Album> CreateAlbumsCollection(string filepath)
    {
        var file = File.ReadAllLines(filepath);
        var albums = new List<Album>();

        for (int i = 0; i < file.Length; i += 6)
        {
            var record = new Album(
                file[i],
                file[i + 1],
                Convert.ToInt32(file[i + 2]),
                Convert.ToInt32(file[i + 3]),
                Convert.ToInt32(file[i + 4]));
            albums.Add(record);
        }

        return albums;
    }

    public static void DisplayAlbumData(List<Album> albums)
    {
        foreach (var album in albums)
        {
            Console.WriteLine(album.BandName);
            Console.WriteLine(album.AlbumTitle);
            Console.WriteLine(album.Tracks);
            Console.WriteLine(album.ReleaseYear);
            Console.WriteLine(album.Downloads);
            Console.Write("\n");
        }
    }
}
internal class Program
{
    public static void Main(string[] args)
    {
        var filepath = "../../../pliki/Data.txt";

        var albums = Album.CreateAlbumsCollection(filepath);
        Album.DisplayAlbumData(albums);
    }
}

// TODO: dokumentacja