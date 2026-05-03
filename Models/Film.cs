namespace TP_MODUL10_103022400112.Models
{
    public class Film
    {
        public string Judul { get; set; }
        public string Sutradara { get; set; }
        public string Tahun { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }

        public Film(string judul, string sutradara, string tahun, string genre, string rating)
        {
            Judul = judul;
            Sutradara = sutradara;
            Tahun = tahun;
            Genre = genre;
            Rating = rating;
        }
    }
}