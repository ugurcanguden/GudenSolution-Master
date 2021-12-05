using Guden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class ProcessTypes : IEntity
    {      
        public ProcessTypes()
        {
            this.InvoiceItems = new HashSet<InvoiceItems>();
        }
        public int Id { get; set; }
        public string ProcessTypeName { get; set; }
        public int Status { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}
