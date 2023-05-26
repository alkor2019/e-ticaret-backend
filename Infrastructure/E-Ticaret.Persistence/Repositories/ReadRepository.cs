using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories;
using E_Ticaret.Domain.Entities.Common;
using E_Ticaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T>
     where T : BaseEntity
    {
         private readonly ETicaretDbContext _context;
        public ReadRepository(ETicaretDbContext context )
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var queries = Table.AsQueryable();
            if(!tracking)
                queries = queries.AsNoTracking();
            return queries;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var queries = Table.AsQueryable();
            if(!tracking)
                queries = queries.AsNoTracking();
            return await queries.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var queries = Table.AsQueryable();
            if(!tracking)
                queries = queries.AsNoTracking();
            
            return await queries.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var queries = Table.AsQueryable();
            if(!tracking)
                queries = queries.AsNoTracking();
            return queries.Where(method);
        }
    }
}