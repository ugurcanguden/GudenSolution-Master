using Guden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class Customers : IEntity
    {

        public Customers()
        {
            this.Invoices = new HashSet<Invoices>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string GSM { get; set; }

        public string Address { get; set; }
        public int Status { get; set; }
        public System.DateTime RegDate { get; set; }

        public decimal TotalInvoiceAmount { get; set; }

        public decimal TotalPaymentAmount { get; set; }

        public Nullable<decimal> RemaningDebt { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
