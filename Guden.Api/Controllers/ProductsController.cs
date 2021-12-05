using Guden.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Guden.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Guden.Core.Entities.Utilities;

namespace Guden.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    [Consumes("application/json")]
 
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetList([FromQuery]PagerRequest request,[FromQuery] int ?  categoryId)
        {
            var result = _productService.GetList(request, categoryId);
            if (result.Success)
            { 
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("add")]
        public IActionResult Add(Products product)
        {
            var result = _productService.Add(product);
            if (result.Success)
                return Ok(result.Message);
            
               return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Products product)
        {
            var result = _productService.Update(product);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Products product)
        {
            var result = _productService.Add(product);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
    }
}
