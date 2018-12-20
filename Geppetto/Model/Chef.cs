using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Chef
    {
        private Menu menu;
        private StorageArea storageArea;
        private Cook cook;

        public int posX { get; set; }
        public int posY { get; set; }

        public Chef()
        {
            this.cook = new Cook(posX,posY);
        }

        public Chef(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

    }
}
