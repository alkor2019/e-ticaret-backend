using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Application.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using E_Ticaret.Application.RequestParamerters;
using E_Ticaret.Application.Abstractions.Storage;
using E_Ticaret.Application.Repositories.ProductImageFiles;
using E_Ticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MediatR;


using E_Ticaret.Application.Features.Queries.ProductQueries.GetAllQuery;
using E_Ticaret.Application.Features.Queries.ProductQueries.GetByIdQuery;
using E_Ticaret.Application.Features.Commands.ProductCommands.CreateCommand;
using E_Ticaret.Application.Features.Commands.ProductCommands.UpdateCommand;
using E_Ticaret.Application.Features.Commands.ProductCommands.RemoveCommand;
using E_Ticaret.Application.Features.Commands.ProductImageCommands.UploadCommand;
using E_Ticaret.Application.Features.Commands.ProductImageCommands.RemoveCommand;
using E_Ticaret.Application.Features.Queries.ProductImageQueries.GetByProductIdQuery;
using Microsoft.AspNetCore.Authorization;

namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class ProductsController : ControllerBase
    {
         private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest request)
        {
             var response = await _mediator.Send(request);
             return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProductQueryRequest request)
        {
             var response = await _mediator.Send(request);
             return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest request)
        {
             var response = await _mediator.Send(request);

             return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductCommandRequest request)
        {
           var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest request)
        {
             var response = await _mediator.Send(request);
             return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadProductImageCommandRequest request)
        {
             request.Files = Request.Form.Files;
             var response = await _mediator.Send(request);
             
             return Ok();
             
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetProductImages([FromRoute] GetByProductIdProductImageQueryRequest request)
        {
            var response = await _mediator.Send(request);
             
             return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageCommandRequest request, [FromQuery] int imageId)
        {
             request.ImageId = imageId;
             var response = await _mediator.Send(request);
             return Ok(response);
        }

    }
}