using System.Collections.Generic;

namespace Music_Album_Creater.BusinessObject
{
    class Album
    {
        private string albumTitle;
        private string artist;
        private string publisher;
        private string genre;
        private List<Song> songs = new List<Song>();
        private Dictionary<string, object> data = new Dictionary<string, object>();

        //Holds the songs that are part of the album.
        public static List<Album> Albums = new List<Album>();

        //Holds the music Genres choices
        public static List<string> MusicGenres = new List<string>
        {
            "Rock",
            "Pop",
            "Hip-Hop",
            "Rap",
            "Country",
            "Jazz",
            "Blues",
            "Electronic",
            "Classical",
            "Reggae",
            "R&B",
            "Metal",
            "Punk",
            "Folk",
            "Soul",
            "Funk",
            "Dance",
            "Alternative",
            "Gospel",
            "Indie",
            "Hip-Hop/Rap",
            "K-Pop",
            "Latin",
            "Disco",
            "Techno",
            "House",
            "EDM",
            "Trance",
            "Dubstep"
        };

        //Holds the options for Music Publishers
        public static List<string> MusicPublishers = new List<string>
        {
            "Universal Music Group",
            "Sony Music",
            "Warner Music Group",
            "EMI",
            "BMG",
            "Columbia Records",
            "Atlantic Records",
            "Capitol Records",
            "Interscope Records",
            "Def Jam Recordings",
            "RCA Records",
            "Republic Records",
            "Virgin Records",
            "Motown Records",
            "Sub Pop Records",
            "Merge Records",
            "Elektra Records",
            "Epic Records",
            "Island Records",
            "Polydor Records",
            "Arista Records",
            "Jive Records",
            "MCA Records",
            "Verve Records",
            "Warner Bros. Records",
            "Sire Records",
            "Nonesuch Records",
            "Rounder Records",
            "XL Recordings"
        };

        public Album()
        {
        }


        public Album(string albumTitle, string artist, string publisher, string genre, List<Song> songs)
        {
            this.songs = new List<Song>();


            foreach (Song song in songs)
            {
                this.songs.Add(song);
            }
            this.albumTitle = albumTitle;
            this.artist = artist;
            this.publisher = publisher;
            this.genre = genre;
        }

        public string AlbumTitle
        {
            get { return albumTitle; }
            set { albumTitle = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public List<Song> Songs
        {
            get { return songs; }
            set {
                if (this.songs is List<Song>) {
                    this.songs = new List<Song>();
                }

                foreach (Song song in value)
                {
                    songs.Add(song);
                }

            }
        }


        public override string ToString()
        {
            List<string> songTitles = new List<string>();
            
            foreach (Song song in this.songs)
            {
                songTitles.Add(song.title);
            }


            return $"Album: {albumTitle} \t " +
                $"Artist: {artist} \t" +
                $"Publisher: {publisher} \t" +
                $"Genre: {genre} \t" +
                $"Songs: {string.Join(", ", songTitles)}";
        }
    }
}
