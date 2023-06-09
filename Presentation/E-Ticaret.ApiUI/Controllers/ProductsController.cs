using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Application.RequestParamerters;
using E_Ticaret.Application.Services;
using E_Ticaret.Application.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
         private readonly IProductReadRepository _productReadRepository;
         private readonly IProductWriteRepository _productWriteRepository;
         private readonly IWebHostEnvironment _webHostEnvironment;
         private readonly IFileService _fileService;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IWebHostEnvironment webHostEnvironment, IFileService fileService)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _webHostEnvironment = webHostEnvironment;
            _fileService = fileService;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery]Pagination pagination)
        {
             var data =  _productReadRepository.GetAll();
             var dataCount = data.Count();
             var products =data
             .Skip(pagination.Page * pagination.Size).Take(pagination.Size)
             .Select(p => new {
                 p.Id,
                 p.CategoryId,
                 p.Name,
                 p.Price,
                 p.UnitsInStock,
                 p.CreatedDate,
                 p.UpdatedDate
             });

          
          
             return Ok(new {
                 products,
                 dataCount
             });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
             var product = await _productReadRepository.GetByIdAsync(id);
             return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Product_Create model)
        {
             if(ModelState.IsValid)
             await _productWriteRepository.AddAsync(new () {
                  CategoryId = model.CategoryId,
                  Name = model.Name,
                  Price = model.Price,
                  UnitsInStock = model.UnitsInStock
             });

             await _productWriteRepository.SaveAsync();

             return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Product_Update model)
        {
            var product = await _productReadRepository.GetByIdAsync(model.Id);
            product.CategoryId = model.CategoryId;
            product.Name = model.Name;
            product.Price = model.Price;
            product.UnitsInStock = model.UnitsInStock;
            await _productWriteRepository.SaveAsync();
            return Ok("Ürün güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
             await _productWriteRepository.RemoveAsync(id);
             await _productWriteRepository.SaveAsync();
             return Ok(new {
                  message = "Ürün başrıyla silindi"
             });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
           await _fileService.UploadFieAsync("resource/product-images", Request.Form.Files);
          return Ok();
        }
    }
}