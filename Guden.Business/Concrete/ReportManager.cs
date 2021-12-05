using Guden.Business.Abstract;
using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;
using Guden.DataAccess.Abstract;
using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }


        public IDataResult<PagerResult<Get_InvoiceReport_Result>> GetInvoiceReportList(PagerRequest pagerRequest, DateTime? beginDate, DateTime? endDate, int? customerId)
        {
            
            var result = Guden.Core.Utilities.ToolUtilities
                        .PagerResult<Get_InvoiceReport_Result>
                        .GetPagerRequest(_reportDal.GetInvoiceReport(beginDate, endDate, customerId), pagerRequest);

            return new SuccessDataResult<PagerResult<Get_InvoiceReport_Result>>(result);
        }

        public IDataResult<PagerResult<Get_PaymentReport_Result>> GetPaymentReportList(PagerRequest pagerRequest, DateTime? beginDate, DateTime? endDate, int? customerId)
        {
            var result = Guden.Core.Utilities.ToolUtilities
                       .PagerResult<Get_PaymentReport_Result>
                       .GetPagerRequest(_reportDal.GetPaymentReport(beginDate, endDate, customerId), pagerRequest);

            return new SuccessDataResult<PagerResult<Get_PaymentReport_Result>>(result);
        }
    }
}
