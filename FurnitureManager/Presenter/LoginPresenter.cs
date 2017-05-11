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
    class LoginPresenter
    {
        private readonly LoginForm loginView;
        private readonly UserData userData;
        private readonly OrderForm orderView;
        private readonly ProductForm productView;
        private readonly UserForm userView;
        private readonly UserOperations userOp;

        public LoginPresenter(LoginForm loginView, UserData userData, OrderForm orderView, ProductForm productView, UserForm userView, UserOperations userOp)
        {
            this.loginView = loginView;
            this.userData = userData;
            this.orderView = orderView;
            this.productView = productView;
            this.userView = userView;
            this.userOp = userOp;
           


            this.loginView.Login += OnLogin;
            

        }

        public void OnLogin()
        {
            var user = this.loginView.RetrieveUser();
         
            
                if (user.IsAdmin.Equals(true))
                {
                    this.userView.Show();
                }
                if (user.IsAdmin.Equals(false))
                {
                    this.orderView.Show();
                    this.productView.Show();
                }
            

            
        }

      
        }

    
}
