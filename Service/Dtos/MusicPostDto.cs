using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class MusicPostDto
    {
        public string? NameSong { get; set; }

        public int MinutesMusic { get; set; }

        public MusicPostDto(string nameSong, int minutesMusic)
        {
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
        }

        public MusicPostDto Load(Music music)
        {
            if (music == null)
                return null;

            NameSong = music.NameSong;
            MinutesMusic = music.MinutesMusic;
            return this;
        }

        public MusicPostDto(Music music)
        {
            Load(music);
        }

        public Music ToEntity()
        {
            return new Music()
            {
                NameSong = NameSong ?? String.Empty,
                MinutesMusic = MinutesMusic,
            };
        }
        public static List<MusicPostDto> ToList(IEnumerable<Music> musics)
        {
            if (musics == null || !musics.Any())
                return new List<MusicPostDto>();
            return musics.Select(music => new MusicPostDto(music)).ToList();
        }
    }
}

