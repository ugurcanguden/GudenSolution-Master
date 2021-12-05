using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;
using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Business.Abstract
{
    public interface IReportService
    {
        IDataResult<PagerResult<Get_InvoiceReport_Result>> GetInvoiceReportList(PagerRequest pagerRequest, DateTime? beginDate, DateTime? endDate, int? customerId);
        IDataResult<PagerResult<Get_PaymentReport_Result>> GetPaymentReportList(PagerRequest pagerRequest, DateTime? beginDate, DateTime? endDate, int? customerId); 

    }
}
