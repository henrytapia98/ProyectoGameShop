using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShopBlazor.Data
{
    public class OrderService
    {
        List<Order> Orders = new List<Order>()
        {
            new Order(){OrderID=1,CustomerName="Mr Jonh",OrderDate=Convert.ToDateTime("01-Mar-2019")},
            new Order(){OrderID=4,CustomerName="ALbert",OrderDate=Convert.ToDateTime("02-Mar-2019")},
            new Order(){OrderID=5,CustomerName="Robert",OrderDate=Convert.ToDateTime("06-Mar-2019")},
            new Order(){OrderID=2,CustomerName="James",OrderDate=Convert.ToDateTime("04-Mar-2019")},
            new Order(){OrderID=3,CustomerName="Petter",OrderDate=Convert.ToDateTime("03-Mar-2019")}
        };

        List<OrderDetails> orderDetails = new List<OrderDetails>()
        {
            new OrderDetails(){OrderID=1, ProductID=1, ProductName="PlayStation 5", ProdQty=1,Price= 850},
            new OrderDetails(){OrderID=2, ProductID=2, ProductName="Nintendo Switch", ProdQty=1,Price=400},
            new OrderDetails(){OrderID=4, ProductID=3, ProductName="GTA V", ProdQty=1,Price=60},
            new OrderDetails(){OrderID=4, ProductID=4, ProductName="GOW 4", ProdQty=1,Price=70},
            new OrderDetails(){OrderID=3, ProductID=5, ProductName="PlayStation 4", ProdQty=2,Price=450},
            new OrderDetails(){OrderID=3, ProductID=6, ProductName="NBA 2K", ProdQty=2,Price=40},
            new OrderDetails(){OrderID=5, ProductID=7, ProductName="Xbox One S", ProdQty=1,Price=300},
            new OrderDetails(){OrderID=5, ProductID=8, ProductName="Fortnite", ProdQty=1,Price=20},
            new OrderDetails(){OrderID=2, ProductID=9, ProductName="Mario Bros", ProdQty=1,Price=50},
            new OrderDetails(){OrderID=2, ProductID=10, ProductName="TLOZ Ocarina of Time", ProdQty=1,Price=60},
            new OrderDetails(){OrderID=7, ProductID=11, ProductName="Nintendo 3ds", ProdQty=1,Price=20},
            new OrderDetails(){OrderID=7, ProductID=12, ProductName="PlayStation VR", ProdQty=3,Price=70},
            new OrderDetails(){OrderID=8, ProductID=13, ProductName="Just Dance 2021", ProdQty=2,Price=60},
        };

        public async Task<List<Order>> OrderList()
        {
            var newOrderList = new List<Order>();
            foreach (var order in Orders)
            {
                order.OrderDetails = orderDetails.Where(s => s.OrderID == order.OrderID).ToList();
                newOrderList.Add(order);
            }
            return await Task.FromResult(newOrderList);
        }
    }
}
