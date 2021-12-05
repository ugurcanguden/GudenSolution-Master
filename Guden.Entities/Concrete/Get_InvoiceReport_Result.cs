using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class Get_InvoiceReport_Result
    {
        public long Id { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public string RegUserName { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public Nullable<decimal> TotalPaymentAmount { get; set; }
        public Nullable<decimal> TotalPaymentCashAmount { get; set; }
        public Nullable<decimal> TotalPaymentCreditCardAmount { get; set; }
    }
}
