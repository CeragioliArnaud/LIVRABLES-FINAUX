using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Table
    {
        public int numberOfPlace { get; set; }
        public int numberTable { get; set; }
        public Boolean avaible { get; set; }
        public Boolean bread { get; set; }
        public Boolean water { get; set; }
        public Boolean served { get; set; }

        public int posX { get; set; }
        public int posY { get; set; }

        public Client client { get; set; }

        public Table(int posX, int posY, int numberOfPlace, int numberTable)
        {
            this.avaible = true;
            this.bread = false;
            this.water = false;
            this.posX = posX;
            this.posY = posY;
            this.numberOfPlace = numberOfPlace;
            this.numberTable = numberTable;
        }
    }
}
