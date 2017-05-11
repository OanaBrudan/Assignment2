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


namespace FurnitureManager.View
{
    public partial class LoginForm : Form
    {
        public event Action Login;
        

        public LoginForm()
        {
            InitializeComponent();
            this.BindComponent();
            textpassword.PasswordChar = '*';
        }

        private void BindComponent()
        {
            this.loginBtn.Click += OnLoginButtonClick;
           
        }

       public User RetrieveUser()
        {
            UserOperations bl = new UserOperations();

            User user = new User();
            user=bl.Login(textusername.Text, textpassword.Text);
            
            return user;
        }

        
        public void OnLoginButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.Login != null)
                {
                    this.Login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        
        }
        

        private void BtnClk(object sender, EventArgs e)
        {
           
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {

        }
      //  private void LoginForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
