using E_Ticaret.Application.Repositories.InvoiceFiles;
using E_Ticaret.Domain.Entities;
using E_Ticaret.Persistence.Contexts;

namespace E_Ticaret.Persistence.Repositories.InvoiceFiles
{
    public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}