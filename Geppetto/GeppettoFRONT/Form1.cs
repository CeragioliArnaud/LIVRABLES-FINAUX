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
using Controller;

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

            Commandes commande = new Commandes();
            CreationSalle restaurantRoom = new CreationSalle();
            CreationCuisine restaurantKit = new CreationCuisine();
            CreationClient client = new CreationClient();
            //Exemple ex = new Exemple();

            SoundPlayer simpleSound = new SoundPlayer(GeppettoFRONT.Properties.Resources.Irish_Tavern);
            simpleSound.Play();

            //////////////////////////////--   SALLE   --/////////////////////////////

            //Musiciens * 3 => Inutiles mais nécéssaires pour l'ambiance. ////
            restaurantRoom.CreateMusicians(MySpriteController);

            //Commis de salle - Soldier Jaune * 1
            restaurantRoom.CreateCommisS(MySpriteController);

            //Serveur - Soldier Orange * 4
            restaurantRoom.CreateWaiters(4, MySpriteController);

            //Chef de rang - Soldier Noir * 2
            restaurantRoom.CreateLChief(2, MySpriteController);

            //Maitre d'hotel - Soldier casqué * 1
            restaurantRoom.CreateButler(MySpriteController);

            //////////////////////////////--   CUISINE   --/////////////////////////////

            //Commis de cuisine - Noir * 2
            restaurantKit.CreateCommisC(2, MySpriteController);

            //Plongeur - Bleu * 1
            restaurantKit.CreatePlong(MySpriteController);

            //Chef de cuisine - Rouge * 1
            restaurantKit.CreateChief(MySpriteController);

            //Chef de parti / Cuisinier - Vert * 2
            restaurantKit.CreateCook(2, MySpriteController);

            ////////////////////////////////////////////////////////////////////

            // Client 
            client.CreateClient(10, MySpriteController);


        }
    }
}
