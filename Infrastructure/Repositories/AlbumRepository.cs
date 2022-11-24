using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Interfaces;


namespace Infrastructure.Repositories
{
    internal class AlbumRepository : Repository<Album>, IRepository<Album>
    {
        public AlbumRepository(Context context) : base(context)
        {
        }
    }
}
