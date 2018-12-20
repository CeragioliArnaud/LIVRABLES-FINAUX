using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Model
    {
        public RestaurationRoom restaurationRoom;
        public Kitchen kitchen;
        public Menu menu;

        public Model()
        {
            restaurationRoom = new RestaurationRoom();
            kitchen = new Kitchen();
            menu = new Menu();
        }
        
    }
}
