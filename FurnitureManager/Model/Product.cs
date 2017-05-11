using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManager.Model
{
   public class Product
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
