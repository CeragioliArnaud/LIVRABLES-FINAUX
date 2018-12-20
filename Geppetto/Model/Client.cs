using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Client
    {
        public int tableNumber { get; set; }
        public Boolean reserve { get; set; }
        public Boolean ordered { get; set; }
        public int addition { get; set; }
        public int numberClients { get; set; }
        public Sprite sprite { get; set; }
        public Etat state ;


        public enum Etat { Arrive, attente, assis, commande, mange, finisRepas, payer , Fini };


        public Client(int numberClients)
        {
            this.numberClients = numberClients;
            this.reserve = false;
            state = Etat.Arrive;
            this.addition = 0;
            ordered = false;
        }
    }
}
