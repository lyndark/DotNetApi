using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class AlbumPutDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ReleaseYear { get; set; }

        public AlbumPutDto(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
        }
        public AlbumPutDto(int id, string name, int releaseYear)
        {
            Id = id;
            Name = name;
            ReleaseYear = releaseYear;
        }
        public AlbumPutDto Load(Album album)
        {
            if (album == null)
                return null;
            Id = album.Id;
            Name = album.Name;
            ReleaseYear = album.ReleaseYear;
            return this;
        }
        public AlbumPutDto(Album album)
        {
            Load(album);
        }
        public Album ToEntity()
        {
            return new Album()
            {
                Id = Id,
                Name = Name ?? String.Empty,
                ReleaseYear = ReleaseYear,
            };
        }

        public static List<AlbumPutDto> ToList(IEnumerable<Album> albums)
        {
            if (albums == null || !albums.Any())
                return new List<AlbumPutDto>();
            return albums.Select(album => new AlbumPutDto(album)).ToList();
        }
    }
}
