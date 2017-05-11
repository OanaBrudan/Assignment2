using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.Model;
using FurnitureManager.DataAccess;
using System.Configuration;

namespace FurnitureManager.View
{
    public class UserOperations
    {
        public User Login(string username, string password)
        {
            UserData dal = new UserData();
            User user = dal.GetUser(username, password);
           return user;
        }

        public void AddUsers(User user)
        {
            UserData dal = new UserData();
            dal.AddUser(user);
        }
     
    }
        
}
