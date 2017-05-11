using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.View;
using FurnitureManager.DataAccess;
using FurnitureManager.Model;


namespace FurnitureManager.Presenter
{
    class OrderPresenter
    {
       // private readonly OrderForm orderView;
       // private readonly OrderForm orderData;
        private readonly IOrderView orderView;
        private readonly OrderData orderData;
        private readonly ReportData reportData;



        public OrderPresenter(IOrderView orderView, OrderData orderData, ReportData reportData)
        {
           
            this.orderView = orderView;
            this.orderData = orderData;
            this.reportData = reportData;

            this.orderView.CreateOrder += OnCreateOrder;
            this.orderView.UpdateOrder += OnUpdateOrder;
            this.orderView.ViewOrder += OnRetrieveOrder;
            this.orderView.OrderSelected += OnOrderSelected;
           
           
        }

        public void OnCreateOrder()
        {
            var order = this.orderView.RetrieveOrder();

            orderData.AddOrder(order);
        }

       
        public void OnUpdateOrder()
        {
            var order = this.orderView.RetrieveOrder();

            orderData.UpdateOrder(order);
        }

        public void OnRetrieveOrder()
        {
            var orders = orderData.RetrieveOrders();
           this.orderView.LoadOrders(orders);
           
        }

        public void OnOrderSelected()
        {
            if (this.orderView.SelectedOrder != null)
            {
                var id = this.orderView.SelectedOrder.ID;
                var order = this.orderData.GetById(id);

                this.orderView.LoadOrder(order);
            }
        }


}}
