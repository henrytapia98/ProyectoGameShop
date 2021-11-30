using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSDataAccess.Models
{
    public class SalesModel
    {
        public int Id_Sale { get; set; }
        public int Id_Product { get; set; }
        public int Id_Client { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Product_Name { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Product_Category { get; set; }
        public string Brand_Name { get; set; }
        public string Game_Category { get; set; }
    }
}
