using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FurnitureManager.Model;

namespace FurnitureManager.Reports
{
   public class FileXML:ReportAbs

    {
       public override string getType()
       {
           return "XML";
       }
       public override void genReport(IList<Report> reports)
       {
           string path = @"F:\rapoarte\xml.txt";
           XmlTextWriter writer = new XmlTextWriter(path, null);
           writer.WriteStartDocument();
           writer.WriteStartElement("reports");
           foreach (Report report in reports)
           {
               writer.WriteStartElement("IDReport");
               writer.WriteString(report.IDReport.ToString());
               writer.WriteEndElement();

               writer.WriteStartElement("Customer");
               writer.WriteString(report.Customer.ToString());
               writer.WriteEndElement();

               writer.WriteStartElement("Status");
               writer.WriteString(report.Status.ToString());
               writer.WriteEndElement();

           }

           writer.WriteEndElement();
           writer.WriteEndDocument();
           writer.Close();
       }
    }
}
