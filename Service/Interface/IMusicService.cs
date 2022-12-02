using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IMusicService
    {
        public Task<MusicDto> Create(MusicPostDto music);
        public Task<MusicDto> Update(MusicPutDto music);
        public Task<MusicDto> Delete(int id);
        public Task<MusicDto> Read(int id);
        public Task<List<MusicDto>> Read();
    }
}
