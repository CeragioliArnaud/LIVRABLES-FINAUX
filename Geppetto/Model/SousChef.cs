using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class SousChef
    {
        private KitchenClerk kitchenClerk;

        private int posX { get; set; }
        private int posY { get; set; }

        public SousChef()
        {
            this.kitchenClerk = new KitchenClerk();
        }

        public SousChef(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
