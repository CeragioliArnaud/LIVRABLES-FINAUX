using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Square
    {
        private int numberSquare { get; set; }
        private List<Rank> ranks;
        private HeadWaiter headWaiter;
        private List<Waiter> waiters;


        public Square(int numberSquare)
        {
            switch (numberSquare)
            {
                case 1:
                    ranks.Add(new Rank(1));
                    ranks.Add(new Rank(2));
                    break;
                case 2:
                    ranks.Add(new Rank(3));
                    ranks.Add(new Rank(4));
                    break;
                default:
                    this.ranks = null;
                    break;
           
            }
            this.numberSquare = numberSquare;
           
            

            headWaiter = new HeadWaiter(50,50);
            waiters.Add(new Waiter(10,20));
            waiters.Add(new Waiter(15,25));

        }
    }
}
