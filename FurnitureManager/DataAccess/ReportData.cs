using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using FurnitureManager.Model;

namespace FurnitureManager.DataAccess
{
    public class ReportData
    {
        private string connString;

        public ReportData()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Report> RetrieveReports()
        {
            IList<Report> reports = new List<Report>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM report";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Report report = new Report();
                        report.IDReport = reader.GetInt32("id");
                        report.Customer = reader.GetString("customer");
                        report.Status = reader.GetString("status");
                        
                        reports.Add(report);
                    }
                }
            }

            return reports;
        }
    }
}
