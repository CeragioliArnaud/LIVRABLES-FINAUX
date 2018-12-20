using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Square
    {
        private int numberSquare { get; set; }
        public List<Rank> ranks;
        public HeadWaiter headWaiter;
        public List<Waiter> waiters;


        public Square(int numberSquare)
        {
            waiters = new List<Waiter>();
            ranks = new List<Rank>();
            switch (numberSquare)
            {
                case 1:
                    ranks.Add(new Rank(1));
                    ranks.Add(new Rank(2));

                    headWaiter = new HeadWaiter(634, 800);

                    waiters.Add(new Waiter(385, 210));
                    waiters.Add(new Waiter(427, 242));
                    break;
                case 2:
                    ranks.Add(new Rank(3));
                    ranks.Add(new Rank(4));

                    headWaiter = new HeadWaiter(1180, 635);

                    waiters.Add(new Waiter(1287, 455));
                    waiters.Add(new Waiter(1325, 125));
                    break;
                default:
                    this.ranks = null;
                    break;

            }
            this.numberSquare = numberSquare;




        }
    }
}
