using Infrastructure.Interfaces;
using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    internal class MusicRepository : Repository<Music>, IRepository<Music>
    {
        public MusicRepository(Context context) : base(context)
        {
        } 
    }
}
