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
    public class AlbumService : IAlbumService
    {
        private IAlbumRepository Repository { get; set; }

        public AlbumService(IAlbumRepository repository)
        {
            Repository = repository;
        }

        public async Task<AlbumDto> Create(AlbumPostDto album)
        {
            var entity = album.ToEntity();
            var result = await Repository.Insert(entity);
            return new AlbumDto(result);
        }

        public async Task<AlbumDto> Delete(int id)
        {
            var result = await Repository.Delete(id);
            return new AlbumDto(result);
        }

        public async Task<AlbumDto> Read(int id)
        {
            var result = await Repository.Select(id);
            return new AlbumDto(result);
        }

        public async Task<List<AlbumDto>> Read()
        {
            var result = await Repository.Select();
            return AlbumDto.ToList(result);
        }

        public async Task<AlbumDto> Update(AlbumPutDto album)
        {
            var entity = album.ToEntity();
            var result = await Repository.Update(entity);
            return new AlbumDto(result);
        }
    }
}
