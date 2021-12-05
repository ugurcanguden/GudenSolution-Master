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
    public interface IInvoiceService
    {
        IDataResult<Invoices> GetById(int productId);
        IDataResult<PagerResult<Invoices>> GetList(PagerRequest pagerRequest,int ? customerId); 
        Result Add(Invoices stock);
        Result Delete(Invoices stock);
        Result Update(Invoices stock);
    }
}
