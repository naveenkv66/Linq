using System;
using System.Linq;
using System.Collections.Generic;


namespace Linq3
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Orders = GetOrders();
            List<string> columns = new List<string>() { "Orderid", "ItemName", "OrderDate", "Quantity" };
            var SortedOrders = Orders.OrderByDescending(item => item.OrderDate).ThenByDescending(item => item.quantity).ToList();
            var SortedOrders2 = (from ordr in Orders
                                group ordr by ordr.OrderDate.Month into o
                                select new
                                {
                                   Month = o.Key,
                                   Count = o.Count()

                                }).ToList();



            Console.WriteLine("{0,4}{1,14}{2,16}{3,10}",
                    "Id", "ItemName", "OrderDate", "Quantity");
            Console.WriteLine();
            SortedOrders.ForEach(item =>
            {
                Console.WriteLine("{0,4}{1,14}{2,16}{3,5}",
                                   item.OrderId, item.ItemName, item.OrderDate.Date.ToShortDateString(),item.quantity);
            });


            Console.WriteLine();

            Console.WriteLine("{0,4}{1,14}",
                   "Month", "Orders Count");
            Console.WriteLine();
            SortedOrders2.ForEach(item =>
            {
                Console.WriteLine("{0,4}{1,14}",
                                   item.Month, item.Count);
            });

            Console.ReadLine();
        }

        static List<Order> GetOrders()
        {
            return new List<Order>()
            {
                new Order(){OrderId=1,OrderDate=new DateTime(2018,7,18),ItemName="product1",quantity=2},
                new Order(){OrderId=2,OrderDate=new DateTime(2018,7,18),ItemName="product2",quantity=4},
                new Order(){OrderId=3,OrderDate=new DateTime(2018,6,22),ItemName="product3",quantity=2},
                new Order(){OrderId=4,OrderDate=new DateTime(2018,7,24),ItemName="product4",quantity=5},
                new Order(){OrderId=5,OrderDate=new DateTime(2018,7,24),ItemName="product5",quantity=4},
                new Order(){OrderId=6,OrderDate=new DateTime(2018,8,3),ItemName="product6",quantity=2},
            };
             
        }


    }
}
 