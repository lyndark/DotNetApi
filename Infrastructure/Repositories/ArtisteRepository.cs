using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class ArtisteRepository : Repository<Artiste>, IRepository<Artiste>
    {
        public ArtisteRepository(Context context) : base(context)
        {
        }
    }
}
