using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    internal class ArtisteRepository : Repository<Artiste>, IRepository<Artiste>
    {
        public ArtisteRepository(Context context) : base(context)
        {
        }
    }
}
