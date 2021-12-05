using Guden.Core.DataAccess.EntityFramework;
using Guden.DataAccess.Abstract;
using Guden.DataAccess.Concrete.EntityFramework.Context;
using Guden.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customers, GudenDatabaseContext>, ICustomerDal
    {
    }
}
