using E_Ticaret.Application.Repositories.FileEntities;
using E_Ticaret.Domain.Entities;
using E_Ticaret.Persistence.Contexts;

namespace E_Ticaret.Persistence.Repositories.FileEntities
{
    public class FileEntityWriteRepository : WriteRepository<FileEntity>, IFileEntityWriteRepository
    {
        public FileEntityWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}