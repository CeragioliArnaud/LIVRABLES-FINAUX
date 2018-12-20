
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class RestaurationRoom
    {
        public List<Square> squares;
        public Butler butler;
        public Clerk clerk;
        public List<Client> clients;
        public RestaurationRoom()
        {
            squares = new List<Square>();
            this.butler = new Butler(1310, 755);
            this.squares.Add(new Square(1));
            this.squares.Add(new Square(2));
            this.clerk = new Clerk(25, 125);
            clients = new List<Client>();
            clients.Add(new Client(3));
            
        }
    }
}
