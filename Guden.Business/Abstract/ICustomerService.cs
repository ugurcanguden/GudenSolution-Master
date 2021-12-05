using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;
using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customers> GetById(int productId);
        IDataResult<PagerResult<Customers>> GetList(PagerRequest pagerRequest); 
        Result Add(Customers stock);
        Result Delete(Customers stock);
        Result Update(Customers stock);
    }
}
