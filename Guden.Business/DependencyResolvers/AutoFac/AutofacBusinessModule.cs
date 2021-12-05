using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Guden.Business.Abstract;
using Guden.Business.Abstract.Core;
using Guden.Business.Concrete;
using Guden.Business.Concrete.Core;
using Guden.Core.Utilities.Interceptors;
using Guden.Core.Utilities.Security.Jwt;
using Guden.DataAccess.Abstract;
using Guden.DataAccess.Abstract.Core;
using Guden.DataAccess.Concrete.EntityFramework;
using Guden.DataAccess.Concrete.EntityFramework.efCore;


namespace Guden.Business.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Category
            builder.RegisterType<CategoryManager>().As<ICategoryService>();            
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            #endregion
            #region Customer
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();
            #endregion
            #region Invoices
            builder.RegisterType<InvoiceManager>().As<IInvoiceService>();
            builder.RegisterType<EfInvoiceDal>().As<IInvoiceDal>();
            #endregion
            #region Payment
            builder.RegisterType<InvoiceItemManager>().As<IInvoiceItemService>();
            builder.RegisterType<EfInvoiceItemDal>().As<IInvoiceItemDal>();
            #endregion
            #region Payments
            builder.RegisterType<PaymentManager>().As<IPaymentService>();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>();
            #endregion
            #region Product
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            #endregion
            #region Stock
            builder.RegisterType<StockManager>().As<IStockService>();
            builder.RegisterType<EfStockDal>().As<IStockDal>();
            #endregion
            #region Report
            builder.RegisterType<ReportManager>().As<IReportService>();
            builder.RegisterType<EfReportDal>().As<IReportDal>();
            #endregion



            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<MenuManager>().As<ICore_MenuService>();
            builder.RegisterType<efCore_MenuDal>().As<IMenuDal>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<efCore_OperationClaimDal>().As<IOperationClaimDal>();
            builder.RegisterType<efCore_UserOperationClaimDal>().As<IUserOperationClaimDal>();

            #region  Interception için yazıldı..
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
            #endregion
        }
    }
}
