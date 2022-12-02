using Infrastructure.Interfaces;
using Service.Dtos;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ArtisteService : IArtisteService
    {
        private IArtisteRepository Repository { get; set; }

        public ArtisteService(IArtisteRepository repository)
        {
            Repository = repository;
        }

        public async Task<ArtisteDto> Create(ArtistePostDto artiste)
        {
            var entity = artiste.ToEntity();
            var result = await Repository.Insert(entity);
            return new ArtisteDto(result);
        }

        public async Task<ArtisteDto> Update(ArtistePutDto album)
        {
            var entity = album.ToEntity();
            var result = await Repository.Update(entity);
            return new ArtisteDto(result);

        }

        public async Task<ArtisteDto> Delete(int id)
        {
            var result = await Repository.Delete(id);
            return new ArtisteDto(result);
        }

        public async Task<ArtisteDto> Read(int id)
        {
            var result = await Repository.Select(id);
            return new ArtisteDto(result);
        }

        public async Task<List<ArtisteDto>> Read()
        {
            var result = await Repository.Select();
            return ArtisteDto.ToList(result);
        }
    }
}
