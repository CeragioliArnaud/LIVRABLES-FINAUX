using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Chef
    {
        private Menu menu;
        private StorageArea storageArea;
        private SousChef sousChef;

        private int posX { get; set; }
        private int posY { get; set; }

        public Chef()
        {
            this.sousChef = new SousChef();
        }

        public Chef(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

    }
}
