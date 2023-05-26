using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.Categories;
using Microsoft.AspNetCore.Mvc;
using E_Ticaret.Domain.Entities;
namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoriesController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // await _categoryWriteRepository.AddRangeAsync(new() {
            //     new(){Name="Elektronik"},
            //     new(){Name="Beyaz Eşya"},
            //     new(){Name="Hırdavat"},
            //     new(){Name="Giyim"}
            // });
            var category = await _categoryReadRepository.GetSingleAsync(x => x.Id == 3, false);
            category.CreatedDate = category.CreatedDate;
            category.Name = "Kasap";
            _categoryWriteRepository.Update(category);
            await _categoryWriteRepository.SaveAsync();
            var categories = _categoryReadRepository.GetAll();
            return Ok(categories);
        }
    }
}