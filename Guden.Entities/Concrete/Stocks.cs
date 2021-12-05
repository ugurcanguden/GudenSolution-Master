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
    public partial class Get_PaymentReport : IEntity
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int StockAmount { get; set; } 
        public System.DateTime StockDate { get; set; }   
        public string Comment { get; set; }
        public int Status { get; set; }
        [ForeignKey("RegUser")]
        public int RegUserId { get; set; }
        public System.DateTime RegDate { get; set; }
        [ForeignKey("UpdateUser")]
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        [ForeignKey("DeleteUser")]
        public Nullable<int> DeleteUserId { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public virtual Products Product { get; set; }
        public virtual Core_User RegUser { get; set; }
        public virtual Core_User UpdateUser { get; set; }
        public virtual Core_User DeleteUser { get; set; }
    }
}
