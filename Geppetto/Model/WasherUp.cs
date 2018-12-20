using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class WasherUp
    {

        public int posX { get; set; }
        public int posY { get; set; }

        public Sprite sprite { get; set; }

        public WasherUp(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
