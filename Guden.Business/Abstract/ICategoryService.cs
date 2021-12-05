using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guden.Core.Utilities.Results;
using Guden.DataAccess.Concrete;
using Guden.Entities.Concrete;

namespace Guden.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Categories> GetById(int categoryId);
        IDataResult<List<Categories>> GetList();
    }
}
