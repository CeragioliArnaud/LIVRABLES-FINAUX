using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class KitchenChef
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public Sprite sprite;

        public List<Order> commands;
    
        public KitchenChef(int posX, int posY)
        {
            commands = new List<Order>();
            this.posX = posX;
            this.posY = posY;
        }
    }
}
