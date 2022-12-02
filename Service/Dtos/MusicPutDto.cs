using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class MusicPutDto
    {
        public int Id { get; set; }
        public string? NameSong { get; set; }

        public int MinutesMusic { get; set; }

        public MusicPutDto(string nameSong, int minutesMusic)
        {
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
        }
        public MusicPutDto(int id, string nameSong, int minutesMusic)
        {
            NameSong = nameSong;
            MinutesMusic = minutesMusic;
            Id = id;
        }

        public MusicPutDto Load(Music music)
        {
            if (music == null)
                return null;

            NameSong = music.NameSong;
            MinutesMusic = music.MinutesMusic;
            Id = music.Id;
            return this;
        }

        public MusicPutDto(Music music)
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
            };
        }
        public static List<MusicPutDto> ToList(IEnumerable<Music> musics)
        {
            if (musics == null || !musics.Any())
                return new List<MusicPutDto>();
            return musics.Select(music => new MusicPutDto(music)).ToList();
        }
    }
}
