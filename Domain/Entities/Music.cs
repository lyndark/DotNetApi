namespace Domain.Entities
{
    public class Music : Entity
    {
        public string NameSong { get; set; }

        public int MinutesMusic { get; set; }

        public int Likes { get; set; }

        public Music()
        {
            NameSong = string.Empty;
            MinutesMusic = 0;
            Likes = 0;  
        }

        public Music(string nameSong, int minutesMusic, int likes)
        {
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
            Likes = likes;
        }

        public Music(int id, string nameSong, int minutesMusic, int likes)
        {
            Id = id;
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
            Likes = likes;
        }
    }
}