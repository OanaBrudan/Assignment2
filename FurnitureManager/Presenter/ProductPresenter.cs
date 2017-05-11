using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.View;
using FurnitureManager.DataAccess;

namespace FurnitureManager.Presenter
{
    class ProductPresenter
    {
        private readonly ProductData productData;
        private readonly ProductForm productView;

        public ProductPresenter( ProductForm productView, ProductData productData)
        {
            this.productData = productData;
            this.productView = productView;

            this.productView.CreateProduct += OnCreateProduct;
            this.productView.UpdateProduct += OnUpdateProduct;
            this.productView.ViewProduct += OnRetrieveProduct;
            this.productView.DeleteProduct += OnDeleteProduct;
            this.productView.ProductSelected += OnSelectedProduct;
  
        }

        public void OnCreateProduct()
        {
            var product = this.productView.RetrieveProduct();

            productData.AddProduct(product);
        }

        public void OnUpdateProduct()
        {
            var product = this.productView.RetrieveProduct();

            productData.UpdateProduct(product);
        }

        public void OnDeleteProduct()
        {
            var product = this.productView.RetrieveProduct();

            productData.DeleteProduct(product);
        }

        public void OnRetrieveProduct()
        {
            var products = productData.RetrieveProducts();
            this.productView.LoadProducts(products);
        }

        public void OnSelectedProduct()
        {
            if (this.productView.SelectedProduct != null)
            {
                var id = this.productView.SelectedProduct.ID;
                var product = this.productData.GetById(id);

                this.productView.LoadProduct(product);
            }
        }
    }
}
