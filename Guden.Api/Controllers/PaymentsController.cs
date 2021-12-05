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

    public class PaymentController : Controller
    {
        private IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("getall")]
        public IActionResult GetList([FromQuery] PagerRequest request, [FromQuery] int ? productId)
        {
            var result = _paymentService.GetList(request, productId);
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
        public IActionResult GetById(int paymentId)
        {
            var result = _paymentService.GetById(paymentId);
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
        public IActionResult Add(Payments payment)
        {
            var result = _paymentService.Add(payment);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Payments payment)
        {
            var result = _paymentService.Update(payment);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Payments payment)
        {
            var result = _paymentService.Add(payment);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);

        }
    }
}
