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
    public interface IStockService
    {
        IDataResult<Get_PaymentReport> GetById(int productId);
        IDataResult<PagerResult<Get_PaymentReport>> GetList(PagerRequest pagerRequest,int ? productId); 
        Result Add(Get_PaymentReport stock);
        Result Delete(Get_PaymentReport stock);
        Result Update(Get_PaymentReport stock);
    }
}
