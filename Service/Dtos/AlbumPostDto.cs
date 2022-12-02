using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class AlbumPostDto
    {
        public string? Name { get; set; }
        public int ReleaseYear { get; set; }

        public AlbumPostDto(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
        }
        public AlbumPostDto Load(Album album)
        {
            if (album == null)
                return null;

            Name = album.Name;
            ReleaseYear = album.ReleaseYear;
            return this;
        }
        public AlbumPostDto(Album album)
        {
            Load(album);
        }
        public Album ToEntity()
        {
            return new Album()
            {
                Name = Name ?? String.Empty,
                ReleaseYear = ReleaseYear,
            };
        }

        public static List<AlbumDto> ToList(IEnumerable<Album> albums)
        {
            if (albums == null || !albums.Any())
                return new List<AlbumDto>();
            return albums.Select(album => new AlbumDto(album)).ToList();
        }
    }
}

