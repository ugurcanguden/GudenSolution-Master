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
    public interface IPaymentService
    {
        IDataResult<Payments> GetById(int productId); 
        IDataResult<PagerResult<Payments>> GetList(PagerRequest pagerRequest, int ? invoiceId); 
        Result Add(Payments stock);
        Result Delete(Payments stock);
        Result Update(Payments stock); 
    }
}
