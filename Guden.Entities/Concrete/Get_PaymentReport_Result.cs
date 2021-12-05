using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class Get_PaymentReport_Result
    {
        public long Id { get; set; }
        public string PaymentName { get; set; }
        public string PaymentDate { get; set; }
        public string CustomerName { get; set; }
        public string RegUserName { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public Nullable<decimal> PaymentTotalAmount { get; set; }
        public Nullable<decimal> PaymentCashAmount { get; set; }
        public Nullable<decimal> PaymentCreditCardAmount { get; set; }
    }
}
