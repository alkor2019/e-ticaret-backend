using E_Ticaret.Application.Abstractions.Storage;
using E_Ticaret.Application.Repositories.ProductImageFiles;
using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Domain.Entities;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductImageCommands.UploadCommand
{
    public class UploadProductImageCommandHandler : IRequestHandler<UploadProductImageCommandRequest, UploadProductImageCommandResponse>
    {
         private readonly IStorageService _storageService;
         private readonly IProductReadRepository _productReadRepository;
         private readonly IProductWriteRepository _productWriteRepository;
         private readonly IProductImageFileWriteRepository _productImageFileWriteRepository;

        public UploadProductImageCommandHandler(IStorageService storageService, IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IProductImageFileWriteRepository productImageFileWriteRepository)
        {
            _storageService = storageService;
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _productImageFileWriteRepository = productImageFileWriteRepository;
        }

        public async Task<UploadProductImageCommandResponse> Handle(UploadProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _storageService.UploadAsync("product-images", request?.Files);
             Product product = await _productReadRepository.GetByIdAsync(request.Id);
             

             await _productImageFileWriteRepository.AddRangeAsync(result.Select(f => new ProductImageFile{
                    Path= f.path,
                    FileName = f.fileName,
                    StorageName = _storageService.StorageName,
                    Products = new List<Product>(){product}
             }).ToList());
             await _productWriteRepository.SaveAsync();
             return new(){
                Message = "Resimler yüklendi",
                Success = true
             };
        }
    }
}