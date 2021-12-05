using Guden.Core.Entities;
using Guden.Core.Entities.Concrete.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class Payments : IEntity
    {
        public int Id { get; set; }
        public string PaymentName { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal PaymentCashAmount { get; set; }
        public decimal PaymentCreditCardAmount { get; set; }
        public Nullable<decimal> PaymentTotalAmount { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
        [ForeignKey("RegUser")]
        public int RegUserId { get; set; } 
        public System.DateTime RegDate { get; set; }
        [ForeignKey("LastUpdateUser")]
        public Nullable<int> LastUpdateUserId { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        [ForeignKey("DeleteUser")]
        public Nullable<int> DeleteUserId { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public virtual Core_User RegUser { get; set; }
        public virtual Core_User LastUpdateUser { get; set; }
        public virtual Core_User DeleteUser { get; set; }
        public virtual Invoices Invoice { get; set; }
    }
}
