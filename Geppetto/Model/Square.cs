using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Square
    {
        //do we need a specific number for the 
       // private int numberSquare { get; set; }
        private List<Rank> ranks;
        private HeadWaiter headWaiter;
        private List<Waiter> waiters;


        public Square(/*int numberSquare*/)
        {
            //this.numberSquare = numberSquare;
            ranks.Add(new Rank());
            ranks.Add(new Rank());

            headWaiter = new HeadWaiter(50,50);
            waiters.Add(new Waiter(10,20));
            waiters.Add(new Waiter(15,25));

        }
    }
}
