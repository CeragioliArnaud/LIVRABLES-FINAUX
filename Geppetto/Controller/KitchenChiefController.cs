using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    class KitchenChiefController
    {
        Model model;
        Commandes commandes;
        public KitchenChiefController(Model model)
        {
            this.model = model;
            this.commandes = new Commandes(model);
            Task butlerTask = new Task(() => WatchLoop());
            butlerTask.Start();


        }

        public void WatchLoop()
        {
            int count = 0;

            while (true)
            {
                Thread.Sleep(8000);
                if (model.kitchen.order.Count > 0)
                {
                    
                    Console.WriteLine("Le thread de gestion du chef de cuisine est lancé");
                    var x = model.kitchen.order.Count;
                    for (int i = 0; i < model.kitchen.order.Count; i++)
                    {
                        model.kitchen.kitchenChef.commands.Add(model.kitchen.order[i]);
                        foreach (Order com in model.kitchen.kitchenChef.commands)
                        {
                            Console.WriteLine(model.kitchen.order[0].plats[0]);
                            com.plats.Add(model.kitchen.order[i].plats[0]);
                            model.kitchen.order[i].plats.Remove(model.kitchen.order[i].plats[0]);
                        }
                    }
                }



                if (model.kitchen.kitchenChef.commands.Count > 0)
                {
                    Console.WriteLine(model.kitchen.kitchenChef.commands.Count);
                    if (count % 2 == 0)
                    {
                        model.kitchen.cooks[0].commands.Add(model.kitchen.kitchenChef.commands[0]);
                        model.kitchen.kitchenChef.commands.Remove(model.kitchen.kitchenChef.commands[0]);
                        model.kitchen.cooks[0].isAvailable = false;
                        Console.WriteLine("Le plat " + model.kitchen.cooks[0].commands[0].plats[0] + " à été affecté au chef 0");
                    }
                    else
                    {
                        model.kitchen.cooks[1].commands.Add(model.kitchen.kitchenChef.commands[0]);
                        model.kitchen.kitchenChef.commands.Remove(model.kitchen.kitchenChef.commands[0]);
                        model.kitchen.cooks[1].isAvailable = false;
                        Console.WriteLine("Le plat " + model.kitchen.cooks[1].commands[0].plats[0] + " à été affecté au chef 1");                    
                    }
                    count++;
                }




            }
        }
    }
}