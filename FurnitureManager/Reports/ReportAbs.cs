using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.Model;
namespace FurnitureManager.Reports
{
    public abstract class ReportAbs
    {
        abstract public string getType();
        abstract public void genReport(IList<Report> reports);
    }
}
