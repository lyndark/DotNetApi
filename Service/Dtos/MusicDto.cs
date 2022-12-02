using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class MusicDto
    {
        public int Id { get; set; }
        public string? NameSong { get; set; }
        public int MinutesMusic { get; set; }
        public int Likes { get; set; }
        public MusicDto(string nameSong, int minutesMusic, int likes)
        {
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
            Likes = likes;
        }
        public MusicDto(int id, string nameSong, int minutesMusic, int likes)
        {
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
            Likes = likes;
            Id = id;
        }
        public MusicDto Load(Music music) {
            if (music == null)
                return null;

            NameSong = music.NameSong;
            MinutesMusic = music.MinutesMusic;
            Likes = music.Likes;
            Id = music.Id;
            return this;
        }
        public MusicDto(Music music)
        {
            Load(music);
        }
        public Music ToEntity()
        {
            return new Music()
            {
                Id = Id,
                NameSong = NameSong ?? String.Empty,
                MinutesMusic = MinutesMusic,
                Likes = Likes
            };
        }
        public static List<MusicDto> ToList(IEnumerable<Music> musics)
        {
            if(musics == null || !musics.Any())
            return new List<MusicDto>();
            return musics.Select(music => new MusicDto(music)).ToList();
        }
    }   
}
