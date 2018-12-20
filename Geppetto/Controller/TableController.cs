using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class TableController
    {
        Model model;
        Commandes commandes;
        public TableController(Model model)
        {
            this.model = model;
            this.commandes = new Commandes(model);
            Task butlerTask = new Task(() => WatchLoop());
            butlerTask.Start();
        }

        public void WatchLoop()
        {
            Console.WriteLine("Le Task (thread) WatchLoop du tableController est appelé");
            bool getOfLoop = false;
            while (true)
            {
                foreach (Square square in model.restaurationRoom.squares)
                {
                    foreach(Waiter waiter in square.waiters)
                    {
                        foreach (Rank rank in square.ranks)
                        {
                            foreach (Table table in rank.tables)
                            {
                                if(waiter.available == true)
                                {
                                    if (table.client.ordered == false)
                                    {
                                        Console.WriteLine("Le client à la table " + table.numberTable + " passe une commande");
                                        table.client.ordered = true;
                                    }
                                    if (table.bread == false)
                                    {
                                        //commandes pour aller au pain
                                        commandes.Go4Bread(waiter.sprite);
                                        commandes.GoToTable(waiter.sprite, table.numberTable);
                                        table.bread = true;
                                        Console.WriteLine("On va apporter le pain à la table: " + table.numberTable);
                                    }
                                    if (table.served == false)
                                    {
                                        commandes.GoToKitchenPLAT(waiter.sprite);
                                        Console.WriteLine("On va chercher les repas table: " + table.numberTable);
                                        commandes.GoToTable(waiter.sprite, table.numberTable);
                                    }
                                    getOfLoop = true;
                                }
                                
                            }
                            if (getOfLoop) break;
                        }
                        if (getOfLoop) break;
                    }
                    if (getOfLoop) break;
                }
                if (getOfLoop) break;
            }
        }
    }
}
