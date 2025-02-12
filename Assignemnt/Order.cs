using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public int customerId {  get; set; }
        public Order(int orderID, DateTime orderDate, decimal total,int CustomerId)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
            customerId = CustomerId;
        }
        public Order()
        {

        }

        public override string ToString()
            => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
    
}
}
