using Guden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class InvoiceStatuses : IEntity
    {
        public InvoiceStatuses()
        {
            this.Invoices = new HashSet<Invoices>();
        }
        public int Id { get; set; }
        public string InvoiceStatusName { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
