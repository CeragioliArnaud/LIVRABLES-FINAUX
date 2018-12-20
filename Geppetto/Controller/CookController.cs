using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    class CookController
    {
        Model model;
        Commandes commandes;
        public CookController(Model model)
        {
            this.model = model;
            this.commandes = new Commandes(model);
            Task cookTask = new Task(() => WatchLoop());
            cookTask.Start();
        }


        public void WatchLoop()
        {
            Console.WriteLine("Le Task (thread) WatchLoop du cookController est appelé");
            bool getOfLoop = false;
            while (true)
            {
                foreach(Cook cook in model.kitchen.cooks)
                {
                    if(cook.isAvailable == false)
                    {
                            Thread.Sleep(7000);
                            commandes.GoToFridge(cook.sprite);
                            Console.WriteLine("Le cuisinier " + cook.sprite.SpriteName + "va vers le frigo pour prendre des ingrédients");
                            cook.commands.Remove(cook.commands[0]);
                            Thread.Sleep(3000);
                            commandes.GoToKitchenPLAT(cook.sprite);
                            cook.isAvailable = true;
                            Console.WriteLine("Le cuisinier " + cook.sprite.SpriteName + "va déposer des plats pour le serveur");
                            //Pas fait la manipulation dans la base de données
                    }
                }
            }

        }
    }
}
