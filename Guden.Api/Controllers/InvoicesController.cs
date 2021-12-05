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

    public class InvoicesController : Controller
    {
        private IInvoiceService _invoiceService;

        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet("getall")]
        public IActionResult GetList([FromQuery] PagerRequest request, [FromQuery] int ? customerId)
        {
            var result = _invoiceService.GetList(request, customerId);
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
        public IActionResult GetById(int invoiceId)
        {
            var result = _invoiceService.GetById(invoiceId);
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
        public IActionResult Add(Invoices invoice)
        {
            var result = _invoiceService.Add(invoice);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Invoices invoice)
        {
            var result = _invoiceService.Update(invoice);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Invoices invoice)
        {
            var result = _invoiceService.Add(invoice);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
    }
}
