using Guden.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class InvoiceItems : IEntity
    {
        public int Id { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        [ForeignKey("ProcessType")]
        public int ProcessTypeId { get; set; }
        [ForeignKey("Product")]
        public Nullable<int> ProductId { get; set; }
        public int Unit { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> Tax { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Comment { get; set; }
        public virtual Products Product { get; set; }
        public virtual Invoices Invoice { get; set; }
        public virtual ProcessTypes ProcessType { get; set; }
    }
}
