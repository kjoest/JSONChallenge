using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<string> LineItems { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Order()
        {

        }

        public Order(int orderId, List<string> lineItems, DateTime purchaseDate)
        {
            OrderId = orderId;
            LineItems = lineItems;
            PurchaseDate = purchaseDate;

        }
    }
}
