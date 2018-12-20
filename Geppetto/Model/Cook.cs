using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Cook
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public Sprite sprite;
        public List<Order> commands;

        public bool isAvailable;

        public Cook(int posX, int posY)
        {
            commands = new List<Order>();
            this.posX = posX;
            this.posY = posY;
            isAvailable = true;
        }
    }
}
