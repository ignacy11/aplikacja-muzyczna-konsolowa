public class Album(string bandName, string albumTitle, int tracks, int releaseYear, long downloads)
{
    public string BandName = bandName;
    public string AlbumTitle = albumTitle;
    public int Tracks = tracks;
    public int ReleaseYear = releaseYear;
    public long Downloads = downloads;
}
internal class Program
{
    public static void Main(string[] args)
    {
        var file = File.ReadAllLines("/home/ignacy/egzaminy/aplikacja-muzyczna/pliki/Data.txt");

        var records = new List<Album>();

        for (int i = 0; i < file.Length; i += 6)
        {
            var record = new Album(file[i], file[i + 1], Convert.ToInt32(file[i + 2]), Convert.ToInt32(file[i + 3]), Convert.ToInt32(file[i + 4])); // TODO: split lines
            records.Add(record);
        }
    }
}