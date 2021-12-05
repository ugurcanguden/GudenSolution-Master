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
    public partial class Invoices : IEntity
    {
      
        public Invoices()
        {
            this.InvoiceItems = new HashSet<InvoiceItems>();
            this.Payments = new HashSet<Payments>();
        }
        public int Id { get; set; }
        public string InvoiceName { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string Comment { get; set; }
        public bool IsCompleted { get; set; }
        [ForeignKey("RegUser")]
        public int RegUserId { get; set; }
        public System.DateTime RegDate { get; set; }
        [ForeignKey("LastUpdateUser")]
        public Nullable<int> LastUpdateUserId { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        [ForeignKey("DeleteUser")]
        public Nullable<int> DeleteUserId { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        [ForeignKey("InvoiceStatus")]
        public int StatusId { get; set; }
        public Nullable<decimal> TotalPaymentAmount { get; set; }
        public decimal TotalPaymentCashAmount { get; set; }
        public decimal TotalPaymentCreditCardAmount { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Core_User RegUser { get; set; }
        public virtual Core_User LastUpdateUser { get; set; }
        public virtual Core_User DeleteUser { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual InvoiceStatuses InvoiceStatus { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
