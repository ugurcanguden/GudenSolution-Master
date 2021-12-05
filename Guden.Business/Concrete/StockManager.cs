using Guden.Business.Abstract;
using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;
using Guden.DataAccess.Abstract;
using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.Business.Concrete
{
    public class StockManager : IStockService
    {
        private IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public IDataResult<Get_PaymentReport> GetById(int stockId)
        {
            return new SuccessDataResult<Get_PaymentReport>(_stockDal.Get(p => p.Id == stockId));
        }

        public IDataResult<PagerResult<Get_PaymentReport>> GetList(PagerRequest pagerRequest,int ? productId)
        {
            var result = Guden.Core.Utilities.ToolUtilities
                        .PagerResult<Get_PaymentReport>
                        .GetPagerRequest(_stockDal.GetList( s => productId == null || s.ProductId == productId, "Product").ToList(), pagerRequest);
            return new SuccessDataResult<PagerResult<Get_PaymentReport>>(result);
        }

        public Result Add(Get_PaymentReport stock)
        {
            ///Kontroler          
            _stockDal.Add(stock);
            return new SuccessDataResult<Get_PaymentReport>("Messages.StockAdded");
        }

        public Result Delete(Get_PaymentReport stock)
        {
            ///Kontroler
            _stockDal.Delete(stock);
            return new SuccessDataResult<Get_PaymentReport>("Messages.StockDeleted");
        }

        public Result Update(Get_PaymentReport stock)
        {
            ///Kontroler
            _stockDal.Update(stock);
            return new SuccessDataResult<Get_PaymentReport>("Messages.StockUpdated");
        }
    }
}
