using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Application.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using E_Ticaret.Application.RequestParamerters;

namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
         private readonly IProductReadRepository _productReadRepository;
         private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public IActionResult GetAll(Pagination pagination)
        {
             var data = _productReadRepository.GetAll();
             var products = data.Skip(pagination.Page * pagination.Size).Take(pagination.Size);
             int totalCount = data.Count();
             return Ok(new {
                 totalCount = totalCount,
                 products = products
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
             await _productWriteRepository.AddAsync(new () {
                  CategoryId = model.CategoryId,
                  Name = model.Name,
                  Price = model.Price,
                  UnitsInStock = model.UnitsInStock
             });

             await _productWriteRepository.SaveAsync();

             return Ok("Ürün eklendi");
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
             return Ok("Ürün silindi");
        }
    }
}