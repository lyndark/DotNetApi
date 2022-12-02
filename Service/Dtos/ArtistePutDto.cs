using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class ArtistePutDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MusicGenre { get; set; }

        public ArtistePutDto(string name, string musicGenre)
        {
            Name = name;
            MusicGenre = musicGenre;
        }
        public ArtistePutDto(int id, string name, string musicGenre)
        {
            Id = id;
            Name = name;
            MusicGenre = musicGenre;
        }
        public ArtistePutDto Load(Artiste artiste)
        {
            if (artiste == null)
                return null;

            Id = artiste.Id;
            Name = artiste.Name;
            MusicGenre = artiste.MusicGenre;
            return this;
        }
        public ArtistePutDto(Artiste artiste)
        {
            Load(artiste);
        }
        public Artiste ToEntity()
        {
            return new Artiste()
            {
                Id = Id,
                Name = Name ?? String.Empty,
                MusicGenre = MusicGenre ?? String.Empty,
            };
        }
        public static List<ArtistePutDto> ToList(IEnumerable<Artiste> artistes)
        {
            if (artistes == null || !artistes.Any())
                return new List<ArtistePutDto>();
            return artistes.Select(artiste => new ArtistePutDto(artiste)).ToList();
        }
    }
}

