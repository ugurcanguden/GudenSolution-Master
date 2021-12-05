using System;
using Guden.Core.Entities.Concrete.Core;
using Guden.Entities.Concrete.Core;
using Microsoft.EntityFrameworkCore; 
using Guden.Entities.Concrete;

namespace Guden.DataAccess.Concrete.EntityFramework.Context
{
    public class GudenDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ustamyanimda;Integrated Security=True");
        }
        public DbSet<Core_User> Core_Users { get; set; }
        public DbSet<Core_OperationClaim> Core_OperationClaims { get; set; }
        public DbSet<Core_UserOperationClaim> Core_UserOperationClaims { get; set; }
        public DbSet<Core_Menus> Core_Menus { get; set; }
        public DbSet<Core_MenuOperationClaimRel> Core_MenuOperationClaimRel { get; set; }
        public  DbSet<Categories> Categories { get; set; }
        public  DbSet<Customers> Customers { get; set; }
        public  DbSet<Products> Products { get; set; }
        public  DbSet<Get_PaymentReport> Stocks { get; set; }
        public  DbSet<Core_User> Users { get; set; }
        public  DbSet<InvoiceItems> InvoiceItems { get; set; }
        public  DbSet<Invoices> Invoices { get; set; }
        public  DbSet<InvoiceStatuses> InvoiceStatuses { get; set; }
        public  DbSet<Payments> Payments { get; set; }
        public  DbSet<ProcessTypes> ProcessTypes { get; set; }
        public DbSet<Get_InvoiceReport_Result> Get_InvoiceReport_Result { get; set; }

        public DbSet<Get_PaymentReport_Result> Get_PaymentReport_Result { get; set; }



        //public virtual List<Get_InvoiceReport_Result> Get_InvoiceReport(Nullable<System.DateTime> beginDate, Nullable<System.DateTime> endDate, Nullable<int> customerId)
        //{
        //    var beginDateParameter = beginDate.HasValue ?
        //        new ObjectParameter("BeginDate", beginDate) :
        //        new ObjectParameter("BeginDate", typeof(System.DateTime));

        //    var endDateParameter = endDate.HasValue ?
        //        new ObjectParameter("EndDate", endDate) :
        //        new ObjectParameter("EndDate", typeof(System.DateTime));

        //    var customerIdParameter = customerId.HasValue ?
        //        new ObjectParameter("CustomerId", customerId) :
        //        new ObjectParameter("CustomerId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_InvoiceReport_Result>("Get_InvoiceReport", beginDateParameter, endDateParameter, customerIdParameter);
        //}

        //public virtual ObjectResult<Get_PaymentReport_Result> Get_PaymentReport(Nullable<System.DateTime> beginDate, Nullable<System.DateTime> endDate, Nullable<int> customerId)
        //{
        //    var beginDateParameter = beginDate.HasValue ?
        //        new ObjectParameter("BeginDate", beginDate) :
        //        new ObjectParameter("BeginDate", typeof(System.DateTime));

        //    var endDateParameter = endDate.HasValue ?
        //        new ObjectParameter("EndDate", endDate) :
        //        new ObjectParameter("EndDate", typeof(System.DateTime));

        //    var customerIdParameter = customerId.HasValue ?
        //        new ObjectParameter("CustomerId", customerId) :
        //        new ObjectParameter("CustomerId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_PaymentReport_Result>("Get_PaymentReport", beginDateParameter, endDateParameter, customerIdParameter);
        //}

        //public virtual int Update_CustomerDebt(Nullable<int> customerId)
        //{
        //    var customerIdParameter = customerId.HasValue ?
        //        new ObjectParameter("CustomerId", customerId) :
        //        new ObjectParameter("CustomerId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_CustomerDebt", customerIdParameter);
        //}

        //public virtual int Update_InvoicePaymentAmount(Nullable<int> invoiceId)
        //{
        //    var invoiceIdParameter = invoiceId.HasValue ?
        //        new ObjectParameter("InvoiceId", invoiceId) :
        //        new ObjectParameter("InvoiceId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_InvoicePaymentAmount", invoiceIdParameter);
        //}

        //public virtual int Update_InvoiceTotalAmount(Nullable<int> invoiceId)
        //{
        //    var invoiceIdParameter = invoiceId.HasValue ?
        //        new ObjectParameter("InvoiceId", invoiceId) :
        //        new ObjectParameter("InvoiceId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_InvoiceTotalAmount", invoiceIdParameter);
        //}

        //public virtual int Update_ProductStockAmount(Nullable<int> productId)
        //{
        //    var productIdParameter = productId.HasValue ?
        //        new ObjectParameter("ProductId", productId) :
        //        new ObjectParameter("ProductId", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_ProductStockAmount", productIdParameter);
        //}
    }
}
