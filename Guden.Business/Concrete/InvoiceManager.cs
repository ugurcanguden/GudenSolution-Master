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

using Guden.Entities.Concrete;

namespace Guden.Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        private IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        } 

        public IDataResult<PagerResult<Invoices>> GetList(PagerRequest pagerRequest,int ? customerId)
        {
            var result = Guden.Core.Utilities.ToolUtilities
                        .PagerResult<Invoices>
                        .GetPagerRequest(_invoiceDal.GetList(i => customerId == null || i.CustomerId == customerId).ToList(), pagerRequest);

            return new SuccessDataResult<PagerResult<Invoices>>(result);
        }

        public IDataResult<Invoices> GetById(int invoiceId)
        {
            return new SuccessDataResult<Invoices>(_invoiceDal.Get(p => p.Id == invoiceId,"InvoiceItems"));
        }

        public Result Add(Invoices invoice)
        {


            _invoiceDal.Add(invoice);
            return new SuccessDataResult<Invoices>("");
        }

        public Result Delete(Invoices invoice)
        {
            ///Kontroler
            _invoiceDal.Delete(invoice);
            return new SuccessDataResult<Invoices>("");
        }

        public Result Update(Invoices invoice)
        {
            ///Kontroler
            _invoiceDal.Update(invoice);
            return new SuccessDataResult<Invoices>("Messages.InvoiceUpdated");
        }


    }
}
