using E_Ticaret.Application.Abstractions.Storage;
using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Application.Features.Commands.ProductImageCommands.RemoveCommand
{
    public class RemoveProductImageCommandHandler : IRequestHandler<RemoveProductImageCommandRequest, RemoveProductImageCommandResponse>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IStorageService _storageService;

        public RemoveProductImageCommandHandler(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IStorageService storageService)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _storageService = storageService;
        }

        public async Task<RemoveProductImageCommandResponse> Handle(RemoveProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            Product? product = await _productReadRepository.Table.Include(p => p.ProductImageFiles)
            .FirstOrDefaultAsync(x => x.Id == request.Id);

            ProductImageFile? productImageFile = product?.ProductImageFiles.FirstOrDefault(x => x.Id == request.ImageId);
            product?.ProductImageFiles.Remove(productImageFile);

              await _storageService.DeleteAsync(productImageFile.Path, productImageFile.FileName);
            var result = await _productWriteRepository.SaveAsync();

            return result > 0 ? new("Ürün resmi silindi", true) : new("Ürün resmi silinirken bir hata oluştu", false);
        }
    }
}