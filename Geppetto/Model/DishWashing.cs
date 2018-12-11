using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DishWashing
    {
        private WasherUp washerUp;
        private Boolean washingMachine;
        private Boolean dishWasher;

        public DishWashing()
        {
            this.washerUp = new WasherUp();
        }
    }
}
