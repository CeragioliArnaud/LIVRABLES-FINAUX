using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Butler
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public Sprite sprite { get; set; }

        public Butler(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
