using System.Collections.Generic;

namespace Music_Album_Creater.BusinessObject
{
    class Song
    {
        public string title { get; set; }
        public string lyrics { get; set; }


        //Was suppose to be in the frmMain but it wouldn't let me do that. So it has to go here
        public static List<Song> TempSongs = new List<Song>();


        public Song(string title, string lyrics)
        {
            this.title = title;
            this.lyrics = lyrics;
        }

        public override string ToString()
        {
            return "Title " + this.title + "\n" +
                   "Lyrics " + this.lyrics + "\n";
        }
    }
}
