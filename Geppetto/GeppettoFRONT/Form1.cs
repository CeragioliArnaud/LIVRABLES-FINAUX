using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using SpriteLibrary;

namespace GeppettoFRONT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SpriteController MySpriteController;

            InitializeComponent();

            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            MySpriteController = new SpriteController(MainDrawingArea);

            SoundPlayer simpleSound = new SoundPlayer(GeppettoFRONT.Properties.Resources.Irish_Tavern);
            simpleSound.Play();

            //////////////////////////////--   SALLE   --/////////////////////////////

            var ptList = new List<Point>();
            ptList.Add(new Point(100, 500));
            ptList.Add(new Point(300, 200));
            ptList.Add(new Point(800, 500));

            //Musiciens * 3 (CREES JUSTE POUR LE DECOR) => Inutiles mais nécéssaires pour l'ambiance. ////
            Sprite Pianiste = new Sprite(new Point(192, 224), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
            Pianiste.AutomaticallyMoves = true;
            Pianiste.PutBaseImageLocation(new Point(190, 110));
            Pianiste.SetSize(new Size(38, 38));

            Sprite Musi1 = new Sprite(new Point(0,160), MySpriteController,
                    Properties.Resources.BlackMage, 32, 32, 200, 3);
            Musi1.AutomaticallyMoves = true;
            Musi1.PutBaseImageLocation(new Point(245, 155));
            Musi1.SetSize(new Size(38, 38));

            Sprite Musi2 = new Sprite(new Point(0, 160), MySpriteController,
                    Properties.Resources.WhiteMage, 32, 32, 200, 3);
            Musi2.AutomaticallyMoves = true;
            Musi2.PutBaseImageLocation(new Point(135, 155));
            Musi2.SetSize(new Size(38, 38));

            ///////////////////////////////////////////////////////////////////////////////

            //Serveur - Soldier Orange * 4

            Sprite Serveur = new Sprite(new Point(288, 128), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
            Serveur.SetName("Serveur");

            Serveur.AutomaticallyMoves = true;
            Serveur.CannotMoveOutsideBox = true;
            //Serveur.SpriteHitsPictureBox += SpriteBounces;
            Serveur.SetSpriteDirectionDegrees(90);
            Serveur.PutBaseImageLocation(new Point(1300, 800));
            //Serveur.MoveTo(new Point(100, 100));
            Serveur.SpriteInitializes += GoToKitchenVAISSELLE;

            Serveur.SetSize(new Size(36, 36));
            Serveur.MovementSpeed = 10;

            //Chef de rang - Soldier Noir * 2

            Sprite ChefRang = new Sprite(new Point(0, 128), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
            ChefRang.SetName("ChefDeRang");

            ChefRang.AutomaticallyMoves = true;
            ChefRang.CannotMoveOutsideBox = true;
            ChefRang.SpriteHitsPictureBox += SpriteBounces;
            ChefRang.SetSpriteDirectionDegrees(80);
            ChefRang.PutBaseImageLocation(new Point(200, 750));
            //ChefRang.MoveTo(new Point(100, 100));
            ChefRang.MoveTo(ptList);
            ChefRang.SetSize(new Size(36, 36));
            ChefRang.MovementSpeed = 10;

            //Maitre d'hotel - Soldier casqué * 1

            Sprite MaitHot = new Sprite(new Point(0, 0), MySpriteController,
                    Properties.Resources.DwarfSprites, 32, 32, 200, 3);
            MaitHot.SetName("Serveur");

            MaitHot.AutomaticallyMoves = true;
            MaitHot.CannotMoveOutsideBox = true;
            MaitHot.SpriteHitsPictureBox += SpriteBounces;
            MaitHot.SetSpriteDirectionDegrees(80);
            MaitHot.PutBaseImageLocation(new Point(1300, 700));
            //MaitHot.MoveTo(new Point(100, 100));
            MaitHot.SetSize(new Size(36, 36));
            MaitHot.MovementSpeed = 10;

            //////////////////////////////--   CUISINE   --/////////////////////////////

            //Commis - Noir * 2

            Sprite CommisC = new Sprite(new Point(286, 128), MySpriteController,
                    Properties.Resources.Link, 32, 32, 200, 3);
            CommisC.SetName("CommisC");
            CommisC.AutomaticallyMoves = true;
            CommisC.CannotMoveOutsideBox = true;
            CommisC.SpriteHitsPictureBox += SpriteBounces;
            CommisC.SetSpriteDirectionDegrees(80);
            CommisC.PutBaseImageLocation(new Point(200, 400));
            //CommisC.MoveTo(new Point(100, 100));
            CommisC.SetSize(new Size(36, 36));
            CommisC.MovementSpeed = 0;


            //Plongeur - Bleu * 1

            Sprite Plongeur = new Sprite(new Point(96, 128), MySpriteController,
                Properties.Resources.Link, 32, 32, 200, 3);
            Plongeur.SetName("Plongeur");

            Plongeur.AutomaticallyMoves = true;
            Plongeur.CannotMoveOutsideBox = true;
            Plongeur.SpriteHitsPictureBox += SpriteBounces;
            Plongeur.SetSpriteDirectionDegrees(80);
            Plongeur.PutBaseImageLocation(new Point(300, 600));
            //Plongeur.MoveTo(new Point(100, 100));
            Plongeur.SetSize(new Size(36, 36));
            Plongeur.MovementSpeed = 0;

            //Chef - Rouge * 1

            Sprite Chef = new Sprite(new Point(286, 0), MySpriteController,
                Properties.Resources.Link, 32, 32, 200, 3);
            Chef.SetName("Chef");

            Chef.AutomaticallyMoves = true;
            Chef.CannotMoveOutsideBox = true;
            Chef.SpriteHitsPictureBox += SpriteBounces;
            Chef.SetSpriteDirectionDegrees(80);
            Chef.PutBaseImageLocation(new Point(100, 500));
            //Chef.MoveTo(new Point(100, 100));
            Chef.SetSize(new Size(36, 36));
            Chef.MovementSpeed = 0;

            //Chef - Vert * 2

            Sprite Cuisinier = new Sprite(new Point(96, 0), MySpriteController,
                Properties.Resources.Link, 32, 32, 200, 3);
            Cuisinier.SetName("Cuisinier");

            Cuisinier.AutomaticallyMoves = true;
            Cuisinier.CannotMoveOutsideBox = true;
            //Cuisinier.SpriteHitsPictureBox += SpriteBounces;
            Cuisinier.SetSpriteDirectionDegrees(360);
            Cuisinier.PutBaseImageLocation(new Point(200, 50));
            Cuisinier.SetSize(new Size(36, 36));
            Cuisinier.MovementSpeed = 0;

        }

        // Rebondir - pour tests => mais inutile dans la finalité
        private void SpriteBounces(object sender, SpriteEventArgs e)
        {
            Random rnd = new Random();
            int rndnumber = rnd.Next(1, 360);
            Sprite sprite = (Sprite)sender;
            sprite.SetSpriteDirectionDegrees(rndnumber);
            
        }

        //Va en direction de la table
        private void GoToTable(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            //Get + set de X et Y de la Table
            sprite.MoveTo(new Point(100 + 1, 100 + 2)); //param X and Y from table +1 ou +2 selon axe table
        }

        //Méthode pour aller chercher le plat prêt
        private void GoToKitchenPLAT(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var ptKitPL = new List<Point>();
            ptKitPL.Add(new Point(100, 500));
            ptKitPL.Add(new Point(300, 200));
            ptKitPL.Add(new Point(800, 500));
            
            sprite.MoveTo(ptKitPL); //param X and Y from table +1 ou +2 selon axe table
            
        }

        //Méthode pour déposer plat sale
        private void GoToKitchenVAISSELLE(object sender, SpriteEventArgs e)
        {
            Sprite sprite = (Sprite)sender;
            var X = sprite.PictureBoxLocation.X;
            var Y = sprite.PictureBoxLocation.Y;
            var ptKitVSL = new List<Point>();
            
            Console.WriteLine(X);
            
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
            Console.WriteLine(X);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
