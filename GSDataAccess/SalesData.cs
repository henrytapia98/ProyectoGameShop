using GSDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSDataAccess
{
    public class SalesData : ISalesData
    {
        private readonly ISqlDataAccess _db;

        public SalesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SalesModel>> GetSales()
        {
            string sql = "Select * from dbo.Sales";
            return _db.LoadData<SalesModel, dynamic>(
                sql,
                new
                {
                });
        }

        public Task InsertSales(SalesModel sales)
        {
            string sql = @"insert into dbo.Sales (First_Name, Last_Name, Product_Name, Price, Quantity, Product_Category, Brand_Name, Game_Category)
                    values (@First_Name, @Last_Name, @Product_Name, @Price, @Quantity, @Product_Category, @Brand_Name, @Game_Category);";

            return _db.SaveData(sql, sales);
        }
    }
}
