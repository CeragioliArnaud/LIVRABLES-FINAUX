using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class KitchenClerk
    {
        private StorageArea storageArea;

        private int posX { get; set; }
        private int posY { get; set; }

        public KitchenClerk()
        {
            this.storageArea = new StorageArea();
        }

        public KitchenClerk(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
