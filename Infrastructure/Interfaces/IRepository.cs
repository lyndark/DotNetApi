

using Domain.Entities;

namespace Infrastructure.Interfaces
{
    internal interface IRepository<T>where T: Entity
    {
        Task<T> Select(int id);

        Task<List<T>> Select();

        Task<T> Delete(int id);

        Task<T> Insert(T entity);

        Task<T> Update(T entity);


    }
}
