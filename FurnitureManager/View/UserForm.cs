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
    public partial class UserForm : Form
    {
        public event Action Add;
        public event Action Delete;
        public event Action Update;
        public event Action View;
        public event Action UserSelected;
        public event Action GenerateReport;

        public UserForm()
        {
            InitializeComponent();
            this.BindComponent();
        }

        private void BindComponent()
        {
            this.addBtn.Click += OnAddButtonClick;
            this.deleteBtn.Click += OnDeleteButtonClick;
            this.editBtn.Click += OnUpdateButtonClick;
            this.viewBtn.Click += OnViewButtonClick;
            this.addReport.Click += OnGenerateReportClick;
            this.userListBox.DisplayMember = "Username";
            this.userListBox.SelectedIndexChanged += OnUserListBoxSelectedIndexChanged;
        }

        public string RetrieveReportType()
        {
            return this.textreport.Text;
        }

        public void OnGenerateReportClick(object sender, EventArgs e)
        {
            try
            {
                if (this.GenerateReport != null)
                {
                    this.GenerateReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public User SelectedUser
        {
            get { return this.userListBox.SelectedItem as User; }
        }
        public void LoadUser(User user)
        {
            textid.Text = user.ID.ToString();
            textname.Text = user.Name;
            textaddress.Text = user.Address;
            textusername.Text = user.Username;
            textpassword.Text = user.Password;
        }
        public void LoadUsers(IList<User> user)
        {
            this.userListBox.DataSource = user;
        }

        public User RetrieveUser()
        {
            User user = new User();

            user.ID = Convert.ToInt32(textid.Text);
            user.Name = textname.Text;
            user.Address = textaddress.Text;
            user.Username = textusername.Text;
            user.Password = textpassword.Text;

            return user;
        }

      

        public void OnAddButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.Add != null)
                {
                    this.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnDeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.Delete != null)
                {
                    this.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnUpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.Update != null)
                {
                    this.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OnViewButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.View != null)
                {
                    this.View();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnUserListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.UserSelected != null)
                {
                    this.UserSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void addclk(object sender, EventArgs e)
        {
           
               
        }

        private void editclk(object sender, EventArgs e)
        {
           
        }

        private void deleteclk(object sender, EventArgs e)
        {
            
        }

        private void retrieveclk(object sender, EventArgs e)
        {
            
        }

        private void EmptyControls()
        {
            
        }
        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
