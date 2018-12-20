using System;
using System.Collections.Generic;
using System.Drawing;
using SpriteLibrary;

namespace Project
{
    //new Model();
    public class Commandes
    {
        //////////////////////////////--   CUISINE   --/////////////////////////////
        Model model;

        public Commandes(Model model)
        {
            this.model = model;
        }

        public void LetsOrder(Client cli)
        {
            model.kitchen.order.Add(new Order());
            Random rnd = new Random();
            int nbOrder = rnd.Next(0, 8);
            cli.ordered = true;
            for (int i = 0; i < nbOrder; i++)
            {
                model.kitchen.order[0].plats.Add(model.menu.plats[i]);
                Console.WriteLine(model.kitchen.order[0].plats[i] + " à été ajouté ");
            }          
        }

            //Méthode pour déposer plat sale
            public void GoToKitchenVAISSELLE(Sprite sprite)
            {
            var X = sprite.PictureBoxLocation.X;
            var Y = sprite.PictureBoxLocation.Y;
            var ptKitVSL = new List<Point>();

            if (X < 600)
            {
                //Entrée cuisine gauche
                ptKitVSL.Add(new Point(615, Y));
                ptKitVSL.Add(new Point(615, 200));
                ptKitVSL.Add(new Point(700, 200));
                ptKitVSL.Add(new Point(980, 200));
            }
            else
            {
                //Entrée cuisine bas
                ptKitVSL.Add(new Point(1255, Y));
                ptKitVSL.Add(new Point(1255, 415));
                ptKitVSL.Add(new Point(1117, 410));
                ptKitVSL.Add(new Point(1117, 330));

                //Va déposer l'assiette
                ptKitVSL.Add(new Point(1020, 230));
            }

            //Method déposer Assiette ();
            //Do.SomethingNext()
            while (!sprite.SpriteReachedEndPoint) { }
            sprite.MoveTo(ptKitVSL);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
        }

        public void GoToKitchenChief(Sprite sprite)
        {
            var X = sprite.PictureBoxLocation.X;
            var Y = sprite.PictureBoxLocation.Y;
            var ptKitVSL = new List<Point>();

            if (X < 600)
            {
                //Entrée cuisine gauche
                ptKitVSL.Add(new Point(615, Y));
                ptKitVSL.Add(new Point(615, 200));
                ptKitVSL.Add(new Point(700, 200));
                ptKitVSL.Add(new Point(1029, 110));
            }
            else
            {
                //Entrée cuisine bas
                ptKitVSL.Add(new Point(1255, Y));
                ptKitVSL.Add(new Point(1255, 415));
                ptKitVSL.Add(new Point(1117, 410));
                ptKitVSL.Add(new Point(1117, 330));

                //Va déposer l'assiette
                ptKitVSL.Add(new Point(1029, 110));
            }

            while (!sprite.SpriteReachedEndPoint) { }
            sprite.MoveTo(ptKitVSL);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
        }
        //
        //Méthode pour aller chercher le plat prêt
        public void GoToKitchenPLAT(Sprite sprite)
        {
            var X = sprite.PictureBoxLocation.X;
            var Y = sprite.PictureBoxLocation.Y;
            var ptKitPL = new List<Point>();

            if (X < 600)
            {
                //Entrée cuisine gauche
                ptKitPL.Add(new Point(615, Y));
                ptKitPL.Add(new Point(615, 200));
                ptKitPL.Add(new Point(700, 200));

                //Va au prêt à servir
                ptKitPL.Add(new Point(822, 215));
            }
            else
            {
                //Entrée cuisine bas
                ptKitPL.Add(new Point(1255, Y));
                ptKitPL.Add(new Point(1255, 415));
                ptKitPL.Add(new Point(1117, 410));
                ptKitPL.Add(new Point(1117, 330));

                //Va au prêt à servir
                ptKitPL.Add(new Point(955, 260));
            }

            sprite.MoveTo(ptKitPL); //param X and Y from table +1 ou +2 selon axe table
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }

        }

        // Rebondir - pour tests => mais inutile dans la finalité
        public void SpriteBounces(object sender, SpriteEventArgs e)
        {
            Random rnd = new Random();
            int rndnumber = rnd.Next(1, 360);
            Sprite sprite = (Sprite)sender;
            sprite.SetSpriteDirectionDegrees(rndnumber);

        } // A METTRE A LA TOUTE FIN DU CONTROLLER CAR INUTILE DONC PREFERABLE ICI

        //Va en direction de la table
        public void GoToTable(Sprite sprite, int nbTable)
        {
            foreach (Square square in model.restaurationRoom.squares) 
            {
                foreach (Rank rank in square.ranks)
                {
                    foreach(Table table in rank.tables)
                    {
                        if(table.numberTable == nbTable)
                        {
                            Console.WriteLine(sprite.SpriteName + " va à la table " + table.numberTable);
                            sprite.MoveTo(new Point(table.posX+36, table.posY));
                            sprite.AutomaticallyMoves = true;
                            sprite.MovementSpeed = Form1.speed;
                            while (!sprite.SpriteReachedEndPoint) { };
                        }
                    }
                }           
            }
            
            
        }

        //Va en direction du maitre d'hotel
        public void GoToButler(Sprite sprite)
        {
            Console.WriteLine("Le " + sprite.SpriteName + " va vers le maitre d'hôtel");
            sprite.MoveTo(new Point(model.restaurationRoom.butler.posX+32, model.restaurationRoom.butler.posY));
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
        }


        //Va en direction du frigo et le vide selon recette
        public void GoToFridge(Sprite sprite)
        {
            var ptFrid = new List<Point>
            {
                new Point(1240, 260),
                new Point(1400, 110)
            };
            sprite.MoveTo(ptFrid);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
            //viderFrigo();
        }

        //Va en direction du stock
        public void GoToStock(Sprite sprite)
        {
            var ptStk = new List<Point>
            {
                new Point(1240, 260),
                new Point(1462, 180)
            };
            sprite.MoveTo(ptStk);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
        }

        
        //Va en direction de la cuisine
        public void Go2KitFromStk(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptStKit = new List<Point>
            {
                new Point(1240, 260),
                new Point(1080, 110)
            };
            sprite.MoveTo(ptStKit);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
        }

        //A Faire //
        //Le client s'en va du restaurant => entrée
        public void ClientLeave(Sprite sprite)
        {
            var X = sprite.PictureBoxLocation.X;
            var Y = sprite.PictureBoxLocation.Y;
            var ptClLiv = new List<Point>();

            if (X < 600)
            {
                ptClLiv.Add(new Point(615, Y));
            }
            else
            {
                ptClLiv.Add(new Point(1255, Y));
            }
            ptClLiv.Add(new Point(1358, 755));
            ptClLiv.Add(new Point(1370, 900));

            sprite.MoveTo(ptClLiv);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
        }

        public void Go4Bread(Sprite sprite)
        {
            var ptBut = new List<Point>
            {
                new Point(1375, 800),
                new Point(1358, 755)
            };
            sprite.MoveTo(ptBut);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
        }

        public void Go4Dishes(Sprite sprite)
        {
            var ptBut = new List<Point>
            {
                new Point(1375, 800),
                new Point(1358, 755)
            };
            sprite.MoveTo(ptBut);
            sprite.AutomaticallyMoves = true;
            sprite.MovementSpeed = Form1.speed;
            while (!sprite.SpriteReachedEndPoint) { }
        }
    }
}
