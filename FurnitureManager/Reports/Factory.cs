using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManager.Reports
{
    public class Factory
    {
        public ReportAbs createReport(String type)
        {
            if (type.Equals("XML"))
            {
                return new FileXML();
            }
            else if (type.Equals("CSV"))
            {
                return new FileCSV();
            }
            return null;
        }
    }
}
