﻿using Guden.Core.DataAccess;
using Guden.DataAccess.Concrete;
using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Products>
    {
    }
}
