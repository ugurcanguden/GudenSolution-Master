using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guden.Business.Abstract;
using Guden.Core.Contants;
using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;
using Guden.DataAccess.Abstract;
using Guden.DataAccess.Concrete;
using Guden.Entities.Concrete;

namespace Guden.Business.Concrete
{
    public class InvoiceItemManager : IInvoiceItemService
    {
        private IInvoiceItemDal _InvoiceItemDal;

        public InvoiceItemManager(IInvoiceItemDal InvoiceItemDal)
        {
            _InvoiceItemDal = InvoiceItemDal;
        } 

        public IDataResult<PagerResult<InvoiceItems>> GetList(PagerRequest pagerRequest,int ? invoiceId)
        {
            var result = Guden.Core.Utilities.ToolUtilities
                        .PagerResult<InvoiceItems>
                        .GetPagerRequest(_InvoiceItemDal.GetList(i => invoiceId == null || i.InvoiceId == invoiceId, "Product").ToList(), pagerRequest);

            return new SuccessDataResult<PagerResult<InvoiceItems>>(result);
        }

        public IDataResult<InvoiceItems> GetById(int InvoiceItemId)
        {
            return new SuccessDataResult<InvoiceItems>(_InvoiceItemDal.Get(p => p.Id == InvoiceItemId, "Product"));
        }

        public Result Add(InvoiceItems InvoiceItem)
        {


            _InvoiceItemDal.Add(InvoiceItem);
            return new SuccessDataResult<InvoiceItems>("");
        }

        public Result Delete(InvoiceItems InvoiceItem)
        {
            ///Kontroler
            _InvoiceItemDal.Delete(InvoiceItem);
            return new SuccessDataResult<InvoiceItems>("");
        }

        public Result Update(InvoiceItems InvoiceItem)
        {
            ///Kontroler
            _InvoiceItemDal.Update(InvoiceItem);
            return new SuccessDataResult<InvoiceItems>("Messages.InvoiceItemUpdated");
        }


    }
}
