using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Menu
    {
        public List<string> plats { get; set; }

        public Menu()
        {
            plats = new List<string>();

            plats.Add("A1");
            plats.Add("A2");
            plats.Add("A3");
            plats.Add("B1");
            plats.Add("B2");
            plats.Add("B3");
            plats.Add("C1");
            plats.Add("C2");
            plats.Add("C3");
        }
    }
}
