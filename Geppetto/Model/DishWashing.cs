using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DishWashing
    {
        
        private WasherUp washerUp;
        private Boolean washingMachine;
        private Boolean dishWasher;

        public DishWashing()
        {
            this.washerUp = new WasherUp(1,2);
        }
    }
}
