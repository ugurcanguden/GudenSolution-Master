using Guden.Core.DataAccess.EntityFramework;
using Guden.DataAccess.Abstract;
using Guden.DataAccess.Concrete.EntityFramework.Context;
using Guden.Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guden.DataAccess.Concrete.EntityFramework
{
    public class EfReportDal : GudenDatabaseContext, IReportDal
    {
        public List<Get_InvoiceReport_Result> GetInvoiceReport(DateTime? beginDate, DateTime? endDate, int? customerId)
        {

            object[] parameters = {
                  new SqlParameter("@BeginDate",SqlDbType.DateTime) {Value= (beginDate != null ? Convert.ToDateTime(beginDate) : DBNull.Value)},
                  new SqlParameter("@EndDate",SqlDbType.DateTime) {Value= (endDate != null ? Convert.ToDateTime(endDate) : DBNull.Value)},
                  new SqlParameter("@CustomerId",SqlDbType.Int) {Value= DBNull.Value}
                };


            // return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_InvoiceReport_Result>("Get_InvoiceReport", beginDateParameter, endDateParameter, customerIdParameter);

            var results = new GudenDatabaseContext()
                                .Get_InvoiceReport_Result
                                .FromSqlRaw("EXEC Get_InvoiceReport @BeginDate ={0},@EndDate={1},@CustomerId={2}", parameters).ToList();
            ;
            return results;

        }

        public List<Get_PaymentReport_Result> GetPaymentReport(DateTime? beginDate, DateTime? endDate, int? customerId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@BeginDate",(object)beginDate ?? DBNull.Value),
                  new SqlParameter("@EndDate",(object)endDate ?? DBNull.Value),
                  new SqlParameter("@CustomerId",(object)customerId ?? DBNull.Value)
            };
            var results = new GudenDatabaseContext()
                            .Get_PaymentReport_Result.FromSqlRaw("EXEC Get_PaymentReport  @BeginDate = @BeginDate , @EndDate = @EndDate, @CustomerId = @CustomerId", parameters)
                            .ToList();
            return results;
        }
    }
}
