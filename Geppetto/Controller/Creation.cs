using System.Drawing;
using SpriteLibrary;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace Controller
{

    public class CreationSalle
    {

        Commandes tasksS = new Commandes();


        /// Musiciens /// 3
        public void CreateMusicians(SpriteController MySpriteController)
        {
            Sprite Pianiste = new Sprite(new Point(192, 224), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
            Pianiste.AutomaticallyMoves = true;
            Pianiste.PutBaseImageLocation(new Point(190, 110));
            Pianiste.SetSize(new Size(38, 38));

            Sprite Musi1 = new Sprite(new Point(0, 160), MySpriteController,
                    Properties.Resources.BlackMage, 32, 32, 200, 3);
            Musi1.AutomaticallyMoves = true;
            Musi1.PutBaseImageLocation(new Point(245, 155));
            Musi1.SetSize(new Size(38, 38));

            Sprite Musi2 = new Sprite(new Point(0, 160), MySpriteController,
                    Properties.Resources.WhiteMage, 32, 32, 200, 3);
            Musi2.AutomaticallyMoves = true;
            Musi2.PutBaseImageLocation(new Point(135, 155));
            Musi2.SetSize(new Size(38, 38));
        }

        /// Commis de salle /// 1
        public void CreateCommisS(SpriteController MySpriteController)
        {
            Sprite CommisS = new Sprite(new Point(192, 0), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
            CommisS.SetName("CommisS");
            CommisS.AutomaticallyMoves = true;
            CommisS.CannotMoveOutsideBox = true;
            CommisS.PutBaseImageLocation(new Point(1085, 550));
            CommisS.SetSize(new Size(36, 36));
            CommisS.MovementSpeed = 10;
        }

        /// Serveurs /// 4
        public void CreateWaiters(int empNumber, SpriteController MySpriteController)
        {
            Sprite[] Serveur = new Sprite[empNumber];
            for (int i=0; i <= empNumber-1; i++)
            {
                Serveur[i] = new Sprite(new Point(288, 128), MySpriteController,
                        Properties.Resources.DwarfSprites, 32, 32, 200, 3);
                Serveur[i].SetName("Serveur" + i.ToString());
                Serveur[i].AutomaticallyMoves = true;
                Serveur[i].CannotMoveOutsideBox = true;
                //Serveur.SpriteInitializes += tasksS.GoToKitchenPLAT;
                Serveur[i].SetSize(new Size(36, 36));
                Serveur[i].MovementSpeed = 10;
                if (i < 2)
                {
                    Serveur[i].PutBaseImageLocation(new Point(385+ (48 * (i - 1)), 210));   
                }
                else
                {
                    Serveur[i].PutBaseImageLocation(new Point(1410+ (48 * (i - 1)), 725));
                }
            }
        }

        /// Chef de rang /// 2
        public void CreateLChief(int empNumber, SpriteController MySpriteController)
        {
            Sprite[] ChefRang = new Sprite[empNumber];
            for (int i = 0; i <= empNumber - 1; i++)
            {
                ChefRang[i] = new Sprite(new Point(0, 128), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
                ChefRang[i].SetName("ChefDeRang" + i.ToString());
                ChefRang[i].AutomaticallyMoves = true;
                ChefRang[i].CannotMoveOutsideBox = true;
                ChefRang[i].SetSize(new Size(36, 36));
                ChefRang[i].MovementSpeed = 10;

                //Le + dans la position X serait à changer si on veut pas qu'ils se mangent des éléments/murs/tables
                if (i % 2 == 0)
                {
                    ChefRang[i].PutBaseImageLocation(new Point(666 + (48 * (i - 1)), 800));
                }
                else
                {
                    ChefRang[i].PutBaseImageLocation(new Point(1180 + (48 * (i - 1)), 635));
                }
            }
        }

        /// Maître d'hôtel /// 1
        public void CreateButler(SpriteController MySpriteController)
        {
            Sprite MaitHot = new Sprite(new Point(0, 64), MySpriteController,
                Properties.Resources.DwarfSprites, 32, 32, 200, 2);
            MaitHot.SetName("Butler");
            MaitHot.AutomaticallyMoves = true;
            MaitHot.CannotMoveOutsideBox = true;
            MaitHot.PutBaseImageLocation(new Point(1310, 755));
            MaitHot.SetSize(new Size(36, 36));
            MaitHot.MovementSpeed = 10;
        }
    }

    public class CreationCuisine
    {
        Commandes tasksC = new Commandes();

        /// Commis Cuisine /// 2
        public void CreateCommisC(int empNumber, SpriteController MySpriteController)
        {
            Sprite[] CommisC = new Sprite[empNumber];
            for (int i = 0; i <= empNumber - 1; i++)
            {
                CommisC[i] = new Sprite(new Point(286, 128), MySpriteController,
                Properties.Resources.Link, 32, 32, 200, 3);
                CommisC[i].SetName("CommisC" + i.ToString());
                CommisC[i].AutomaticallyMoves = true;
                CommisC[i].CannotMoveOutsideBox = true;
                CommisC[i].PutBaseImageLocation(new Point(1400, 230+(48*i)));
                CommisC[i].SetSize(new Size(36, 36));
                CommisC[i].MovementSpeed = 10;
            }
                
        }
        
        /// Plongeur /// 1
        public void CreatePlong(SpriteController MySpriteController)
        {
            Sprite Plongeur = new Sprite(new Point(96, 128), MySpriteController,
                Properties.Resources.Link, 32, 32, 200, 3);
            Plongeur.SetName("Plongeur");
            Plongeur.AutomaticallyMoves = true;
            Plongeur.CannotMoveOutsideBox = true;
            Plongeur.PutBaseImageLocation(new Point(765, 110));
            Plongeur.SetSize(new Size(36, 36));
            Plongeur.MovementSpeed = 10;
        }

        /// Chef de cuisine /// 1
        public void CreateChief(SpriteController MySpriteController)
        {
            Sprite Chief = new Sprite(new Point(286, 0), MySpriteController,
                Properties.Resources.Link, 32, 32, 200, 3);
            Chief.SetName("Chef");
            Chief.AutomaticallyMoves = true;
            Chief.CannotMoveOutsideBox = true;
            Chief.PutBaseImageLocation(new Point(1050, 110));
            Chief.SpriteInitializes += tasksC.ClientLeave;
            Chief.SetSize(new Size(36, 36));
            Chief.MovementSpeed = 10;
        }

        /// Chef de rang - Cuisinier /// 2
        public void CreateCook(int empNumber, SpriteController MySpriteController)
        {
            Sprite[] Cook = new Sprite[empNumber];
            for (int i = 0; i <= empNumber - 1; i++)
            {
                Cook[i] = new Sprite(new Point(96, 0), MySpriteController,
                    Properties.Resources.Link, 32, 32, 200, 3);
                Cook[i].SetName("Cuisinier" + i.ToString());
                Cook[i].AutomaticallyMoves = true;
                Cook[i].CannotMoveOutsideBox = true;
                Cook[0].PutBaseImageLocation(new Point(955, 110));
                if (i == 1)
                {
                    Cook[1].PutBaseImageLocation(new Point(1212, 110));
                }
                Cook[i].SetSize(new Size(36, 36));
                Cook[i].MovementSpeed = 10;
            }
        }    
    }

    public class CreationClient
    {
        Commandes tasksCl = new Commandes();

        public void CreateClient(int empNumber, SpriteController MySpriteController)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate (object state){ PoolStore(empNumber, MySpriteController); }), null);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(1000);
        }

        static void PoolStore(int empNumber, SpriteController MySpriteController)
        {
            // No state object was passed to QueueUserWorkItem, so stateInfo is null.
            Sprite Client = new Sprite(new Point(96, 0), MySpriteController,
                Properties.Resources.Customers, 32, 32, 200, 3);
            Client.SetName("Chef");
            Client.AutomaticallyMoves = true;
            Client.CannotMoveOutsideBox = true;
            Client.PutBaseImageLocation(new Point(1375, 900));
            Client.SetSize(new Size(36, 36));
            Client.MovementSpeed = 10;
            Console.WriteLine("Hello from the thread pool.");

        }
        /*Sprite[] Client = new Sprite[empNumber];
        for (int i = 0; i < empNumber; i++)
        {
            if (i % 2 == 0)
            {
                Client[i] = new Sprite(new Point(96, 0), MySpriteController,
                Properties.Resources.Customers, 32, 32, 200, 3);
            }
            else
            {
                Client[i] = new Sprite(new Point(96, 96), MySpriteController,
                Properties.Resources.Customers, 32, 32, 200, 3);
            }
            Client[i].SetName("Client" + i.ToString());
            Client[i].AutomaticallyMoves = true;
            Client[i].CannotMoveOutsideBox = true;
            Client[i].PutBaseImageLocation(new Point(1375, 900));
            Client[i].SetSize(new Size(36, 36));
            Client[i].MovementSpeed = 10;
            tasksCl.GoToButler(Client[i]); //On va plutot faire un appel de méthode plutot qu'un event car il y a complication 
        }*/

    }
    /*
    class SpriteTest
    {
        public long CreationTime;
        public int Name;
        public int ThreadNum;
    }

    public class Exemple
    {
        public void Main()
        {
            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew((Object obj) => { SpriteTest client = obj as SpriteTest;
                    if (client == null)
                        return;

                    client.ThreadNum = Thread.CurrentThread.ManagedThreadId;
                },
                                                      new SpriteTest() { Name = i, CreationTime = DateTime.Now.Ticks });
            }
            Task.WaitAll(taskArray);
            foreach (var task in taskArray)
            {
                var data = task.AsyncState as SpriteTest;
                if (data != null)
                    Console.WriteLine("Task #{0} created at {1}, ran on thread #{2}.",
                                      data.Name, data.CreationTime, data.ThreadNum);
            }
        }*/
    }
////CREER LES OBJETS DU MODEL ET GERER SELON POSITION, LES EVENTS