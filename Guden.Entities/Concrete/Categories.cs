using Guden.Core.Entities; 
using System.Collections.Generic; 

namespace Guden.Entities.Concrete
{
    public partial class Categories : IEntity
    {      
        public Categories()
        {
            this.Products = new HashSet<Products>();
        }
        public int Id { get; set; }      
        public string CategoryName { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
