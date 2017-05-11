using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.View;
using FurnitureManager.DataAccess;
using FurnitureManager.Reports;
using FurnitureManager.Model;

namespace FurnitureManager.Presenter
{
    class UserPresenter
    {
        private readonly UserForm userView;
        private readonly UserData userData;
        private readonly ReportData reportData;

        public UserPresenter(UserForm userView, UserData userData, ReportData reportData)
        {
            this.userView = userView;
            this.userData = userData;
            this.reportData = reportData;
            this.userView.Add += OnCreateUser;
            this.userView.Update += OnUpdateUser;
            this.userView.View += OnViewUser;
            this.userView.Delete += OnDeleteUser;
            this.userView.UserSelected += OnUserSelected;
            this.userView.GenerateReport += OnGenerateReport;

        }

        public void OnCreateUser()
        {
            

            var user = this.userView.RetrieveUser();
            userData.AddUser(user);
        }

        public void OnGenerateReport()
        {
            var type = this.userView.RetrieveReportType();
            IList<Report> reports = new List<Report>();
            reports = reportData.RetrieveReports();

            Factory factory = new Factory();
            ReportAbs repAbs = factory.createReport(type);
            repAbs.genReport(reports);

        }
        public void OnUpdateUser()
        {
            
            var user= this.userView.RetrieveUser();
            userData.UpdateUser(user);
        }

        public void OnDeleteUser()
        {
            var user = this.userView.RetrieveUser();
            userData.DeleteUser(user);
        }

        public void OnViewUser()
        {
            var user = userData.RetrieveUsers();
            this.userView.LoadUsers(user);
        }

        public void OnUserSelected()
        {
            if (this.userView.SelectedUser != null)
            {
                var username = this.userView.SelectedUser.Username;
                var password = this.userView.SelectedUser.Password;
                var regularUser = this.userData.GetUser(username, password);

                this.userView.LoadUser(regularUser);
            }
        }


    }
}
