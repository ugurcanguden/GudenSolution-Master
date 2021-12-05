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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<Customers> GetById(int customerId)
        {
            return new SuccessDataResult<Customers>(_customerDal.Get(p => p.Id == customerId));
        }

        public IDataResult<PagerResult<Customers>> GetList(PagerRequest pagerRequest)
        {
            var result = Guden.Core.Utilities.ToolUtilities
                        .PagerResult<Customers>
                        .GetPagerRequest(_customerDal.GetList(null,null).ToList(), pagerRequest);

            return new SuccessDataResult<PagerResult<Customers>>(result);
        }


        public Result Add(Customers customer)
        {


            _customerDal.Add(customer);
            return new SuccessDataResult<Customers>("");
        }

        public Result Delete(Customers customer)
        {
            ///Kontroler
            _customerDal.Delete(customer);
            return new SuccessDataResult<Customers>("");
        }

        public Result Update(Customers customer)
        {
            ///Kontroler
            _customerDal.Update(customer);
            return new SuccessDataResult<Customers>("Messages.CustomerUpdated");
        }
    }
}
