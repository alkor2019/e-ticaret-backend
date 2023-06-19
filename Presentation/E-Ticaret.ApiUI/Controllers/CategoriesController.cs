using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.Categories;
using Microsoft.AspNetCore.Mvc;
using E_Ticaret.Domain.Entities;
using MediatR;
using E_Ticaret.Application.Features.Queries.CategoryQueries.GetAllQuery;

namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCategoryQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}