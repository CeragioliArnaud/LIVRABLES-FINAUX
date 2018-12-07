using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Waiter
    {
        private int posX { get; set; }
        private int posY { get; set; }

        public Waiter(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
