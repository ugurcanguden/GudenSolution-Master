using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.DataAccess.Abstract
{
    public  interface IReportDal
    {
        public List<Get_InvoiceReport_Result> GetInvoiceReport(DateTime? beginDate, DateTime? endDate, int ? customerId);
        public List<Get_PaymentReport_Result> GetPaymentReport(DateTime? beginDate, DateTime? endDate, int ? customerId);
    }
}
