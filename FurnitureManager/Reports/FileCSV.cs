using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using FurnitureManager.Model;

namespace FurnitureManager.Reports
{
   public class FileCSV:ReportAbs
    {

        public override string getType()
       {
           return "CSV";
       }

        public override void genReport(IList<Report> reports)
        {
            string path = @"F:\rapoarte\csv.txt";
            var csv = new StringBuilder();
            foreach (var report in reports)
            {
                var newLine = string.Format("{0},{1},{3}", report.IDReport.ToString(), report.Customer.ToString(), report.Status.ToString());
                csv.AppendLine(newLine);
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(csv);
            }
        }
    }
}
