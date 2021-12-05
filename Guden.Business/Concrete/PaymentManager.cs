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
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public IDataResult<Payments> GetById(int paymentId)
        {
            return new SuccessDataResult<Payments>(_paymentDal.Get(p => p.Id == paymentId));
        } 

        public IDataResult<PagerResult<Payments>> GetList(PagerRequest pagerRequest,int ? invoiceId)
        {
            var result = Guden.Core.Utilities.ToolUtilities
                        .PagerResult<Payments>
                        .GetPagerRequest(_paymentDal.GetList(p => invoiceId == null || p.InvoiceId == invoiceId, "Invoice").ToList(), pagerRequest);
            return new SuccessDataResult<PagerResult<Payments>>(result);
        }


        public Result Add(Payments payment)
        {


            _paymentDal.Add(payment);
            return new SuccessDataResult<Payments>("");
        }

        public Result Delete(Payments payment)
        {
            ///Kontroler
            _paymentDal.Delete(payment);
            return new SuccessDataResult<Payments>("");
        }

        public Result Update(Payments payment)
        {
            ///Kontroler
            _paymentDal.Update(payment);
            return new SuccessDataResult<Payments>("Messages.PaymentUpdated");
        }

       
    }
}
