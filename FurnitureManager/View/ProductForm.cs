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
    public partial class ProductForm : Form
    {

        public event Action CreateProduct;
        public event Action UpdateProduct;
        public event Action DeleteProduct;
        public event Action ViewProduct;
        public event Action ProductSelected;

        public ProductForm()
        {
            InitializeComponent();
            this.BindComponent();
        }

        private void BindComponent()
        {
            this.addBtn.Click += OnCreateProductButtonClick;
            this.editBtn.Click += OnUpdateProductButtonClick;
            this.deleteBtn.Click += OnDeleteProductButtonClick;
            this.viewBtn.Click += OnViewProductButtonClick;

            this.productListBox.DisplayMember = "Title";
            this.productListBox.SelectedIndexChanged += OnProductListBoxSelectedIndexChanged;
        }

        public Product SelectedProduct
        {
            get 
            { 
                return this.productListBox.SelectedItem as Product; 
            }
        }

        public void LoadProducts(IList<Product> products)
        {
            this.productListBox.DataSource = products;
        }

        public Product RetrieveProduct()
        {
            Product product = new Product();
            product.ID = Convert.ToInt32(textid.Text);
            product.Title = texttitle.Text;
            product.Description = textdescription.Text;
            product.Color = textcolor.Text;
            product.Size = textsize.Text;
            product.Price = Convert.ToInt32(textprice.Text);
            product.Stock = Convert.ToInt32(textstock.Text);

            return product;

        }

        public void LoadProduct(Product product)
        {
            textid.Text = product.ID.ToString();
            texttitle.Text = product.Title;
            textdescription.Text = product.Description;
            textcolor.Text = product.Color;
            textsize.Text = product.Size;
            textprice.Text = product.Price.ToString();
            textstock.Text = product.Stock.ToString();
            
        }

        public void OnCreateProductButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.CreateProduct != null)
                {
                    this.CreateProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnUpdateProductButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.UpdateProduct != null)
                {
                    this.UpdateProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnDeleteProductButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.DeleteProduct != null)
                {
                    this.DeleteProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnViewProductButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ViewProduct != null)
                {
                    this.ViewProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnProductListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ProductSelected != null)
                {
                    this.ProductSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void create_clk(object sender, EventArgs e)
        {
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_clk(object sender, EventArgs e)
        {
           
        }

        private void view_clk(object sender, EventArgs e)
        {
           
        }

        private void EmptyControls()
        {
            
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
