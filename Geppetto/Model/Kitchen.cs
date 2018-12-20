using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{

    public class Kitchen
    {

        public KitchenChef kitchenChef;
        public List<Cook> cooks;
        public WasherUp plong;
        public List<Order> order;

        public Kitchen()
        {
            cooks = new List<Cook>();

            plong = new WasherUp(765, 110);

            kitchenChef = new KitchenChef(1055,110);

            cooks.Add(new Cook(955, 110));
            cooks.Add(new Cook(1212,110));

            order = new List<Order>();

            
        }
       
    }
}

