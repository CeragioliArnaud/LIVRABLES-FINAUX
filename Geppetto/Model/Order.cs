using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Order
    {
        public List<string> plats { get; set; }

        public Order()
        {
            plats = new List<string>();
        }
    }
}
