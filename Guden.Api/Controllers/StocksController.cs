using Guden.Business.Abstract;
using Guden.Core.Entities.Utilities;
using Guden.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Guden.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    [Consumes("application/json")]

    public class StocksController : Controller
    {
        private IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("getall")]
        public IActionResult GetList([FromQuery] PagerRequest request, [FromQuery] int ? productId)
        {
            var result = _stockService.GetList(request, productId);
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
        public IActionResult GetById(int stockId)
        {
            var result = _stockService.GetById(stockId);
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
        public IActionResult Add(Get_PaymentReport stock)
        {
            var result = _stockService.Add(stock);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Get_PaymentReport stock)
        {
            var result = _stockService.Update(stock);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Get_PaymentReport stock)
        {
            var result = _stockService.Add(stock);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
    }
}
