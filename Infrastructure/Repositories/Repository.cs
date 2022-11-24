using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly Context context;

        public Repository(Context context)
        {
            this.context = context;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await Select(id);
            if(entity != default)
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }

            return entity;
        }

        public async Task<T> Insert(T entity)
        {
            context.Add(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Select(int id)
        {
            return await context.Set<T>().AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<T>> Select()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
           context.Entry(entity).State= EntityState.Modified;
            await context.SaveChangesAsync();

            return entity;  
        }
    }
}
