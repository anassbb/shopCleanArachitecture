using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public CatalogItemOrdered ItemOrdered { get; private set; }
        public decimal UnitPrice { get; private set; }

        public int  Units { get; private set; }

        public OrderItem(CatalogItemOrdered itemOrdered, decimal unitPrice, int unit)
        {
            ItemOrdered = itemOrdered;
            UnitPrice = unitPrice;
            Units = unit;
        }

        private OrderItem() {}
    }
}
