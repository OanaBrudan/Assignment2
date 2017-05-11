using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManager.Model
{
    public class Order
    {
        
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public Product Product { get; set; }


    }
}
