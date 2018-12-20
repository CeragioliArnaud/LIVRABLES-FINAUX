using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class Controller
    {
        //CreationClient creationClient;
        CreationSalle creationSalle;
        CreationCuisine creationCuisine;
        CreationClient creationClient;
        Commandes commandes;
        KitchenChiefController kit;
        ButlerController butlerController;
        CookController cook;
        TableController tabf;
        Model model;
        Form1 form;

        public Controller()
        {
            model = new Model();
            



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1(model);


            butlerController = new ButlerController(model);
            creationSalle = new CreationSalle(model, form);
            creationCuisine = new CreationCuisine(model, form);
            creationClient = new CreationClient(model, form);
            commandes = new Commandes(model);
            kit = new KitchenChiefController(model);
            cook = new CookController(model);
            tabf = new TableController(model);

            InitPerson();

            Task test = new Task(() => this.Test());
            Task butlerTask = new Task(() => this.Asign());
            Task chief = new Task(() => this.Delegue());
            Task cookT = new Task(() => this.Cooker());

            butlerTask.Start();
            test.Start();
            chief.Start();
            cookT.Start();
            Application.Run(form);
        }
        public void InitPerson()
        {
            // SALLE //
            //creationSalle.CreateCommisS();
            creationSalle.CreateButler();
            creationSalle.CreateWaiters();
            creationSalle.CreateHeadWaiter();

            // CUISINE //
            creationCuisine.CreateChief();
            creationCuisine.CreateCook();
            creationCuisine.CreatePlong();

            // CLIENT //
            creationClient.CreateClient();
        }
        public void Asign()
        {
            butlerController.WatchLoop();
        }


        public void Delegue()
        {
            kit.WatchLoop();
        }

        public void Cooker()
        {
            cook.WatchLoop();
        }


        public void Test()
        {

            while (true)
            {

                if (model.restaurationRoom.clients[0].state == Client.Etat.attente)
                {
                    commandes.GoToButler(model.restaurationRoom.clients[0].sprite);
                    commandes.GoToButler(model.restaurationRoom.squares[0].headWaiter.sprite);

                    model.restaurationRoom.clients[0].state = Client.Etat.assis;



                    /*commandes.GoToButler(model.restaurationRoom.clients[0].sprite);
                    commandes.GoToButler(model.restaurationRoom.squares[0].headWaiter.sprite);
                    commandes.GoToTable(model.restaurationRoom.squares[0].waiters[0].sprite, 3);
                    commandes.GoToTable(model.restaurationRoom.clients[0].sprite, 3);
                    Console.WriteLine("Le client va maintenant passer une commande");
                    commandes.LetsOrder(model.restaurationRoom.clients[0]);

                    Thread.Sleep(2000);
                    Console.WriteLine("Le serveur va déclarer les ordres au chef");
                    commandes.GoToKitchenChief(model.restaurationRoom.squares[0].waiters[0].sprite);
                    kit.WatchLoop();*/


                }
                else if (model.restaurationRoom.clients[0].state == Client.Etat.assis)
                {
                    commandes.GoToTable(model.restaurationRoom.squares[0].headWaiter.sprite, model.restaurationRoom.clients[0].tableNumber);
                    commandes.GoToTable(model.restaurationRoom.clients[0].sprite, model.restaurationRoom.clients[0].tableNumber);
                    model.restaurationRoom.clients[0].state = Client.Etat.commande;
                }
                else if (model.restaurationRoom.clients[0].state == Client.Etat.commande)
                {

                    commandes.GoToTable(model.restaurationRoom.squares[0].waiters[0].sprite ,model.restaurationRoom.clients[0].tableNumber);
                    commandes.LetsOrder(model.restaurationRoom.clients[0]);
                    Thread.Sleep(2000);
                    commandes.GoToKitchenChief(model.restaurationRoom.squares[0].waiters[0].sprite);
                    int a = model.kitchen.order.Count;
                    Console.WriteLine(a);
                    model.restaurationRoom.clients[0].state = Client.Etat.mange;



                }
                else if (model.restaurationRoom.clients[0].state == Client.Etat.mange)
                {

                }
                else if (model.restaurationRoom.clients[0].state == Client.Etat.finisRepas)
                {

                }
                else if (model.restaurationRoom.clients[0].state == Client.Etat.payer)
                {

                }
                else if (model.restaurationRoom.clients[0].state == Client.Etat.Fini)
                {

                }
            }

            //commandes.GoToTable(model.restaurationRoom.clients[0].sprite, model.restaurationRoom.clients[0].tableNumber);
        }
    }
    
}
