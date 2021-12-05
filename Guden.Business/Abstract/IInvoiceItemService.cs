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
    public interface IInvoiceItemService
    {
        IDataResult<InvoiceItems> GetById(int productId);
        IDataResult<PagerResult<InvoiceItems>> GetList(PagerRequest pagerRequest,int ? customerId); 
        Result Add(InvoiceItems stock);
        Result Delete(InvoiceItems stock);
        Result Update(InvoiceItems stock);
    }
}
