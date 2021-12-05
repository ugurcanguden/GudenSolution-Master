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

    public class InvoiceItemsController : Controller
    {
        private IInvoiceItemService _invoiceItemService;

        public InvoiceItemsController(IInvoiceItemService invoiceItemService)
        {
            _invoiceItemService = invoiceItemService;
        }

        [HttpGet("getall")]
        public IActionResult GetList([FromQuery] PagerRequest request, [FromQuery] int ? invoiceId)
        {
            var result = _invoiceItemService.GetList(request, invoiceId);
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
        public IActionResult GetById(int invoiceItemId)
        {
            var result = _invoiceItemService.GetById(invoiceItemId);
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
        public IActionResult Add(InvoiceItems invoiceItem)
        {
            var result = _invoiceItemService.Add(invoiceItem);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(InvoiceItems invoiceItem)
        {
            var result = _invoiceItemService.Update(invoiceItem);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult Delete(InvoiceItems invoiceItem)
        {
            var result = _invoiceItemService.Add(invoiceItem);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
    }
}
