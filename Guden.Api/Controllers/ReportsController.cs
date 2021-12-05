using Guden.Business.Abstract;
using Guden.Core.Entities.Utilities;
using Guden.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Guden.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    [Consumes("application/json")]

    public class ReportsController : Controller
    {
        private IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("getpaymentreport")]
        public IActionResult GetPaymentReportList([FromQuery] PagerRequest request, [FromQuery] DateTime? beginDate, [FromQuery] DateTime? endDate, [FromQuery] int? customerId)
        {
            var result = _reportService.GetPaymentReportList(request,beginDate,endDate,customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getinvoicereport")]
        public IActionResult GetInvoiceReportList([FromQuery] PagerRequest request, [FromQuery] DateTime? beginDate, [FromQuery] DateTime? endDate, [FromQuery] int? customerId)
        {
            var result = _reportService.GetInvoiceReportList(request, beginDate, endDate, customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

    }
}
