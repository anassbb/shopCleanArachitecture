using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.OrderAggregate
{
    public class Order: BaseEntity
    {
        private Order() { }


        public Order(string buyerId, Address shipAddress, List<OrderItem> items)
        {
            BuyerId = buyerId;
            ShipAddress = shipAddress;
            _orderItem = items;
        }

        public string   BuyerId { get; private set; }
        public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.Now;

        public Address ShipAddress { get; private set; }

        public readonly List<OrderItem> _orderItem = new List<OrderItem>();

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItem.AsReadOnly();

        public decimal Total() 
        
        {
            var total = 0m;
            foreach (var item in _orderItem)
            {
                total += item.UnitPrice * item.Units;
            }

            return total;
        
        }
    }
}
