using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAlbumService
    {
        public Task<AlbumDto> Create(AlbumPostDto album);
        public Task<AlbumDto> Update(AlbumPutDto album);
        public Task<AlbumDto> Delete(int id);
        public Task<AlbumDto> Read(int id);
        public Task<List<AlbumDto>> Read();
    }
}
