using GSDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSDataAccess
{
    public interface ISalesData
    {
        Task<List<SalesModel>> GetSales();
        Task InsertSales(SalesModel sales);
    }
}