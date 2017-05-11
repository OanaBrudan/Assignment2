using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.Model;

namespace FurnitureManager.View
{
    interface IOrderView
    {
        event Action CreateOrder;
        event Action UpdateOrder;
        event Action OrderSelected;
        event Action ViewOrder;

        void LoadOrder(Order order);
        Order RetrieveOrder();
        void LoadOrders(IList<Order> orders);
        Order SelectedOrder
        {
            get;
        }
        
    }
}
