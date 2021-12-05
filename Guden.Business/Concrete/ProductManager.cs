using System;
using System.Collections.Generic;
using System.Linq;
using Guden.Business.Abstract;
using Guden.Business.ValidationRules.FluentValidation;
using Guden.Core.Aspects.Autofac.Validation;
using Guden.Core.Contants;
using Guden.Core.CrossCuttingConcerns.Validation;
using Guden.Core.Entities.Utilities;
using Guden.Core.Utilities.Results;

using Guden.DataAccess.Abstract;
using Guden.DataAccess.Concrete;
using Guden.Entities.Concrete;

namespace Guden.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        
        public IDataResult< Products> GetById(int productId)
        {
            return new SuccessDataResult<Products>(_productDal.Get(p => p.Id == productId));
        }

        public IDataResult<PagerResult<Products>> GetList(PagerRequest pagerRequest, int ? categoryId)
        {
                var result=  Guden.Core.Utilities.ToolUtilities
                            .PagerResult<Products>
                            .GetPagerRequest(_productDal.GetList(p => categoryId == null || p.CategoryId == categoryId,"Stocks").ToList(),  pagerRequest);

            return new SuccessDataResult<PagerResult<Products>>(result);
        }
        public Result Add(Products product)
        {
            ///Kontroler
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
            return new SuccessDataResult<Products>( Messages.ProductAdded);
        }

        public Result Delete(Products product)
        {
            ///Kontroler
            _productDal.Delete(product);
            return new SuccessDataResult<Products>(Messages.ProductDeleted);
        }

        public Result Update(Products product)
        {
            ///Kontroler
            _productDal.Update(product);
            return new SuccessDataResult<Products>(Messages.ProductUpdated);
        }
    }
}
