using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        private int numberOfPlace { get; set; }
        private int numberTable { get; set; }
        private Boolean avaible { get; set; }
        private Boolean bread { get; set; }
        private Boolean water { get; set; }
        private int posX { get; set; }
        private int posY { get; set; }

        public Table(int posX, int posY, int numberOfPlace)
        {
            this.avaible = true;
            this.bread = false;
            this.water = false;
            this.posX = posX;
            this.posY = posY;
            this.numberOfPlace = numberOfPlace;
        }
    }
}
