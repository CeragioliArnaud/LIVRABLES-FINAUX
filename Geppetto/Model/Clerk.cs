using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Clerk
    {
        private int posX { get; set; }
        private int posY { get; set; }
        public Sprite sprite { get; set; }
        public Clerk(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
