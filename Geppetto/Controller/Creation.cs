using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpriteLibrary;

namespace Project
{
    public class CreationSalle
    {
        Model model;
        Form1 form;
        //Commandes tasksS = new Commandes();


        public CreationSalle(Model model, Form1 form)
        {
            this.model = model;
            this.form = form;
        }

        /// Maitre d'hôtel /// 1
        public void CreateButler()
        {
            model.restaurationRoom.butler.sprite = new Sprite(new Point(0, 64), form.spriteController, Geppetto.Properties.Resources.DwarfSprites, 32, 32, 200, 2);
            model.restaurationRoom.butler.sprite.SetName("Butler");
            model.restaurationRoom.butler.sprite.PutBaseImageLocation(new Point(model.restaurationRoom.butler.posX, model.restaurationRoom.butler.posY));
            model.restaurationRoom.butler.sprite.CannotMoveOutsideBox = true;
            model.restaurationRoom.butler.sprite.SetSize(new Size(32, 32));
            model.restaurationRoom.butler.sprite.MoveTo(new Point(model.restaurationRoom.butler.posX, model.restaurationRoom.butler.posY));
            model.restaurationRoom.butler.sprite.AutomaticallyMoves = true;
            model.restaurationRoom.butler.sprite.MovementSpeed = 10;
        }

        /// Serveurs /// 4
        public void CreateWaiters()
        {
            foreach (Square square in model.restaurationRoom.squares)
            {
                foreach (Waiter waiter in square.waiters)
                {
                    waiter.sprite = new Sprite(new Point(288, 128), form.spriteController, Geppetto.Properties.Resources.DwarfSprites, 32, 32, 200, 3);
                    waiter.sprite.SetName("Waiter");
                    waiter.sprite.PutBaseImageLocation(new Point(waiter.posX, waiter.posY));
                    waiter.sprite.CannotMoveOutsideBox = true;
                    waiter.sprite.SetSize(new Size(32, 32));
                    waiter.sprite.MoveTo(new Point(waiter.posX, waiter.posY));
                    waiter.sprite.AutomaticallyMoves = true;
                    waiter.sprite.MovementSpeed = 10;
                }
            }
        }

        // Chef de rang // 2
        public void CreateHeadWaiter()
        {
            foreach (Square square in model.restaurationRoom.squares)
            {
                square.headWaiter.sprite = new Sprite(new Point(0, 128), form.spriteController, Geppetto.Properties.Resources.DwarfSprites, 32, 32, 200, 3);
                square.headWaiter.sprite.SetName("HServeur");
                square.headWaiter.sprite.PutBaseImageLocation(new Point(square.headWaiter.posX, square.headWaiter.posY));
                square.headWaiter.sprite.CannotMoveOutsideBox = true;
                square.headWaiter.sprite.SetSize(new Size(32, 32));
                square.headWaiter.sprite.MoveTo(new Point(square.headWaiter.posX, square.headWaiter.posY));
                square.headWaiter.sprite.AutomaticallyMoves = true;
                square.headWaiter.sprite.MovementSpeed = 10;
            }
        }
    }

    public class CreationCuisine
    {
        Model model;
        Form1 form;
        //Commandes tasksS = new Commandes();


        public CreationCuisine(Model model, Form1 form)
        {
            this.model = model;
            this.form = form;
        }


        /// Commis Cuisine /// 2
        public void CreateCook()
        {
            foreach (Cook cook in model.kitchen.cooks)
            {
                cook.sprite = new Sprite(new Point(96, 0), form.spriteController, Geppetto.Properties.Resources.Link, 32, 32, 200, 3);
                cook.sprite.SetName("Cook");
                cook.sprite.PutBaseImageLocation(new Point(cook.posX, cook.posY));
                cook.sprite.CannotMoveOutsideBox = true;
                cook.sprite.SetSize(new Size(32, 32));
                cook.sprite.MoveTo(new Point(cook.posX, cook.posY));
                cook.sprite.AutomaticallyMoves = true;
                cook.sprite.MovementSpeed = 10;
            }
        }

        public void CreateChief()
        {
            model.kitchen.kitchenChef.sprite = new Sprite(new Point(286, 0), form.spriteController, Geppetto.Properties.Resources.Link, 32, 32, 200, 3);
            model.kitchen.kitchenChef.sprite.SetName("Chef");
            model.kitchen.kitchenChef.sprite.PutBaseImageLocation(new Point(model.kitchen.kitchenChef.posX, model.kitchen.kitchenChef.posY));
            model.kitchen.kitchenChef.sprite.CannotMoveOutsideBox = true;
            model.kitchen.kitchenChef.sprite.SetSize(new Size(32, 32));
            model.kitchen.kitchenChef.sprite.MoveTo(new Point(model.kitchen.kitchenChef.posX, model.kitchen.kitchenChef.posY));
            model.kitchen.kitchenChef.sprite.AutomaticallyMoves = true;
            model.kitchen.kitchenChef.sprite.MovementSpeed = 10;
        }

        public void CreatePlong()
        {
            model.kitchen.plong.sprite = new Sprite(new Point(96, 128), form.spriteController, Geppetto.Properties.Resources.Link, 32, 32, 200, 3);
            model.kitchen.plong.sprite.SetName("Plongeur");
            model.kitchen.plong.sprite.PutBaseImageLocation(new Point(model.kitchen.plong.posX, model.kitchen.plong.posY));
            model.kitchen.plong.sprite.AutomaticallyMoves = true;
            model.kitchen.plong.sprite.CannotMoveOutsideBox = true;
            model.kitchen.plong.sprite.SetSize(new Size(36, 36));
            model.kitchen.plong.sprite.MovementSpeed = 10;
        }
    }

    public class CreationClient
    {
        Model model;
        Form1 form;
        //Commandes tasksS = new Commandes();


        public CreationClient(Model model, Form1 form)
        {
            this.model = model;
            this.form = form;
        }

        public void CreateClient()
        {
            foreach(Client client in model.restaurationRoom.clients)
            {
                client.sprite = new Sprite(new Point(286, 0), form.spriteController, Geppetto.Properties.Resources.Link, 32, 32, 200, 3);
                client.sprite.SetName("Client");
                client.sprite.PutBaseImageLocation(new Point(1375, 900));
                client.sprite.CannotMoveOutsideBox = true;
                client.sprite.SetSize(new Size(32, 32));
                client.sprite.AutomaticallyMoves = true;
                client.sprite.MovementSpeed = 10;
            }
            
        }

    }
}

