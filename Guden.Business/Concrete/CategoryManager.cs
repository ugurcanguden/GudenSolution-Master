using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guden.Business.Abstract;
using Guden.Core.Utilities.Results;
using Guden.DataAccess.Abstract;
using Guden.DataAccess.Concrete;
using Guden.Entities.Concrete;

namespace Guden.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<Categories> GetById(int categoryId)
        {
            return new SuccessDataResult<Categories>(_categoryDal.Get(p=>p.Id==categoryId));
        }

        public IDataResult<List<Categories>> GetList()
        {
            return new SuccessDataResult<List<Categories>>(_categoryDal.GetList(null).ToList());
        }
    }
}
