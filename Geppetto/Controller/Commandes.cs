using System;
using System.Collections.Generic;
using System.Drawing;
using SpriteLibrary;

namespace Controller
{
    public class Commandes
    {
        //////////////////////////////--   CUISINE   --/////////////////////////////

        //Méthode pour déposer plat sale
        public void GoToKitchenVAISSELLE(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
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

            sprite.MoveTo(ptKitVSL); //param X and Y from table +1 ou +2 selon axe table
        }

        //Méthode pour aller chercher le plat prêt
        public void GoToKitchenPLAT(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
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
        public void GoToTable(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            //Get + set de X et Y de la Table
            sprite.MoveTo(new Point(100 + 1, 100 + 2)); //param X and Y from table +1 ou +2 selon axe table
        }

        //Va en direction du maitre d'hotel
        public void GoToButler(Sprite sprite)
        {
            //Sprite sprite = (Sprite)sender;
            var ptBut = new List<Point>();
            ptBut.Add(new Point(1375, 800));
            ptBut.Add(new Point(1358, 755));
            sprite.MoveTo(ptBut);
        }
        

        //Va en direction du frigo et le vide selon recette
        public void GoToFridge(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptFrid = new List<Point>();
            ptFrid.Add(new Point(1240, 260));
            ptFrid.Add(new Point(1400, 110));
            sprite.MoveTo(ptFrid);
            //TODO Requete vider dans la BDD
        }

        //Va en direction du stock
        public void GoToStock(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptStk = new List<Point>();
            ptStk.Add(new Point(1240, 260));
            ptStk.Add(new Point(1462, 180));
            sprite.MoveTo(ptStk);
            if (sprite.SpriteName == "CommisC0" || sprite.SpriteName == "CommisC1")
            {
                Console.WriteLine("Ok, ca marche l'accès");
                //TODO méthode vider dans stock dans la BDD
            }
            else
            {
                Console.WriteLine("Nope");
                Console.WriteLine(sprite.SpriteName);
            }
        }

        
        //Va en direction de la cuisine
        public void Go2KitFromStk(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptStKit = new List<Point>();
            ptStKit.Add(new Point(1240, 260));
            ptStKit.Add(new Point(1080, 110));
            sprite.MoveTo(ptStKit);
        }

        //A Faire //
        //Le client s'en va du restaurant => entrée
        public void ClientLeave(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
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
        }

        public void Go4Bread(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptBut = new List<Point>();
            ptBut.Add(new Point(1375, 800));
            ptBut.Add(new Point(1358, 755));
            sprite.MoveTo(ptBut);
        }

        public void Go4Dishes(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptBut = new List<Point>();
            ptBut.Add(new Point(1375, 800));
            ptBut.Add(new Point(1358, 755));
            sprite.MoveTo(ptBut);
        }
    }
}
