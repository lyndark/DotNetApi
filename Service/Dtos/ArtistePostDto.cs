using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class ArtistePostDto
    {
        public string? Name { get; set; }
        public string? MusicGenre { get; set; }

        public ArtistePostDto(string name, string musicGenre)
        {
            Name = name;
            MusicGenre = musicGenre;
        }
        public ArtistePostDto Load(Artiste artiste)
        {
            if (artiste == null)
                return null;

            Name = artiste.Name;
            MusicGenre = artiste.MusicGenre;
            return this;
        }
        public ArtistePostDto(Artiste artiste)
        {
            Load(artiste);
        }
        public Artiste ToEntity()
        {
            return new Artiste()
            {
                Name = Name ?? String.Empty,
                MusicGenre = MusicGenre ?? String.Empty,
            };
        }
        public static List<ArtisteDto> ToList(IEnumerable<Artiste> artistes)
        {
            if (artistes == null || !artistes.Any())
                return new List<ArtisteDto>();
            return artistes.Select(artiste => new ArtisteDto(artiste)).ToList();
        }
    }
}

