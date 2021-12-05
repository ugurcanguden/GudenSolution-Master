using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;
using Guden.DataAccess.Concrete;
using Guden.Entities.Concrete;

namespace Guden.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Products> GetById(int productId);
        IDataResult<PagerResult<Products>> GetList(PagerRequest pagerRequest,int ? categoryId);
        Result Add(Products product);
        Result Delete(Products product);
        Result Update(Products product);


    }
}
