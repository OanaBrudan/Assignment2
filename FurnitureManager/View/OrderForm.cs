using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureManager.Model;
using FurnitureManager.DataAccess;

namespace FurnitureManager.View
{
    public partial class OrderForm : Form, IOrderView
    {
        public event Action CreateOrder;
        public event Action UpdateOrder;
        public event Action ViewOrder;
        public event Action OrderSelected;
      
        private string exceptionMessage { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            this.BindComponent();
        }

        private void BindComponent()
        {
            this.addOrder.Click += OnCreateOrderClick;
            this.editOrder.Click += OnUpdateOrderClick;
            this.retrieveOrder.Click += OnViewOrderClick;
            
            this.orderListBox.DisplayMember = "Customer";
            this.orderListBox.SelectedIndexChanged += OnOrderListBoxSelectedIndexChanged;

        }

        


        public Order SelectedOrder
        {
            get
            {
                return this.orderListBox.SelectedItem as Order;
            }
        }

        public void LoadOrders(IList<Order> orders)
        {
            this.orderListBox.DataSource = orders;
        }

        public void LoadOrder(Order order)
        {
            txtid.Text = order.ID.ToString();
            txtcustomer.Text = order.Customer;
            txtaddress.Text = order.Address;
            txtdate.Value = order.Date;
            txtstatus.Text = order.Status;
        }

        public Order RetrieveOrder()
        {
            Order order = new Order();
            order.ID = Convert.ToInt32(txtid.Text);
            order.Customer = txtcustomer.Text;
            order.Address = txtaddress.Text;
            order.Date = txtdate.Value;
            order.Status = txtstatus.Text;

            return order;


        }

        
        public void OnCreateOrderClick(object sender, EventArgs e)
        {
            try
            {
                if (this.CreateOrder != null)
                {
                    this.CreateOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnUpdateOrderClick(object sender, EventArgs e)
        {
            try
            {
                if (this.UpdateOrder != null)
                {
                    this.UpdateOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnViewOrderClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ViewOrder != null)
                {
                    this.ViewOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnOrderListBoxSelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (this.OrderSelected != null)
                {
                    this.OrderSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

 
    }
}
