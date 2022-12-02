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
    public class MusicService : IMusicService
    {
        private IMusicRepository Repository { get; set; }

        public MusicService(IMusicRepository repository)
        {
            Repository = repository;
        }
        public async Task<MusicDto> Create(MusicPostDto music)
        {
            var entity = music.ToEntity();
            var result = await Repository.Insert(entity);
            return new MusicDto(result);
        }

        public async Task<MusicDto> Delete(int id)
        {
            var result = await Repository.Delete(id);
            return new MusicDto(result);
        }

        public async Task<MusicDto> Read(int id)
        {
            var result = await Repository.Select(id);
            return new MusicDto(result);
        }

        public async Task<List<MusicDto>> Read()
        {
            var result = await Repository.Select();
            return MusicDto.ToList(result);
        }

        public async Task<MusicDto> Update(MusicPutDto music)
        {
            var entity = music.ToEntity();
            var result = await Repository.Update(entity);
            return new MusicDto(result);
        }
    }
}
