using Guden.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Entities.Concrete
{
    public partial class Products:IEntity
    {      
        public Products()
        {
            this.Stocks = new HashSet<Get_PaymentReport>();
            this.InvoiceItems = new HashSet<InvoiceItems>();
        }
        public int Id { get; set; }      
        public string ProductName { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }       
        public decimal Price { get; set; }
        public int Status { get; set; }      
        public int StockAmount { get; set; }      
        public Nullable<int> OrderStockAmount { get; set; }       
        public Nullable<int> StockNetAmount { get; set; }
        public virtual Categories Category { get; set; }
        public virtual ICollection<Get_PaymentReport> Stocks { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}
