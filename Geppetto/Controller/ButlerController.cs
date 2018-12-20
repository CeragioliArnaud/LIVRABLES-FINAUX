using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ButlerController
    {
        Model model;
        Commandes commandes;
        public ButlerController(Model model)
        {
            this.model = model;
            Task butlerTask = new Task(() => WatchLoop());
            butlerTask.Start();
        }


        public void WatchLoop()
        {
            Console.WriteLine("Le Task (thread) WatchLoop du tableController est appelé");
            bool getOfLoop = false;
            while (true)
            {
                getOfLoop = false;


                foreach ( Client client in model.restaurationRoom.clients)
                {
                    if ( client.state == Client.Etat.Arrive)
                    {
                        foreach (Square square in model.restaurationRoom.squares)
                        {
                            foreach (Rank rank in square.ranks)
                            {
                                foreach (Table table in rank.tables)
                                {
                                    if (table.avaible == true && table.numberOfPlace >= client.numberClients)
                                    {
                                        Console.WriteLine("la table " + table.numberTable + " a été assigné");
                                        table.avaible = false;
                                        table.client = client;
                                        //Added
                                        client.tableNumber = table.numberTable;
                                        client.state = Client.Etat.attente;
                                        Console.WriteLine(client.state);
                                        client.tableNumber = table.numberTable;
                                       // model.restaurationRoom.clients.Remove(client);
                                        getOfLoop = true;
                                        break;
                                    }
                                }
                                break;
                            }
                            break;
                        }
                       
                    }
                }



                
                   
                
            }
        }
    }
}
