using FurnitureManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureManager.Model;
using FurnitureManager.DataAccess;
using FurnitureManager.Presenter;
using FurnitureManager.View;

namespace FurnitureManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new OrdersF());
            //Application.Run(new ProductsF());
           // Application.Run(new UsersF());
            //Application.Run(new LoginForm());

            var uD = new UserData();
            var pD = new ProductData();
            var oD = new OrderData();
            var lF = new LoginForm();
            var oF = new OrderForm();
            var pF = new ProductForm();
            var uF = new UserForm();
            var uO = new UserOperations();
            var rD = new ReportData();

            var uP = new UserPresenter(uF,uD,rD );
            var oP = new OrderPresenter(oF, oD, rD);
            var pP = new ProductPresenter(pF, pD);
            var lP = new LoginPresenter(lF, uD,oF, pF, uF, uO );

            Application.Run(lF);
        }
    }
}
///cment