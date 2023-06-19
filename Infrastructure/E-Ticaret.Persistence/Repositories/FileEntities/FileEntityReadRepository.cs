using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.FileEntities;
using E_Ticaret.Domain.Entities;
using E_Ticaret.Persistence.Contexts;

namespace E_Ticaret.Persistence.Repositories.FileEntities
{
    public class FileEntityReadRepository : ReadRepository<FileEntity>, IFileEntityReadRepository
    {
        public FileEntityReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}