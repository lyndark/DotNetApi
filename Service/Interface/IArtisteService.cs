using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IArtisteService
    {
        public Task<ArtisteDto> Create(ArtistePostDto artiste);
        public Task<ArtisteDto> Update(ArtistePutDto album);
        public Task<ArtisteDto> Delete(int id);
        public Task<ArtisteDto> Read(int id);
        public Task<List<ArtisteDto>> Read();
    }
}
