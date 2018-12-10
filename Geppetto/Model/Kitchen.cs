using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    class Kitchen
    {
        private Chef chef;
        private DishWashing dishWashing;
        private StorageArea storageArea;
        private SousChef sousChef;
        private KitchenClerk kitchenClerk;
        private WasherUp washerUp;

        public Kitchen()
        {
            this.dishWashing = new DishWashing();
            chef = new Chef(50, 60);
            washerUp = new WasherUp(40, 30);
            sousChef = new SousChef(30, 50);
            kitchenClerk = new KitchenClerk(40, 30);
        }
        
    }
}
