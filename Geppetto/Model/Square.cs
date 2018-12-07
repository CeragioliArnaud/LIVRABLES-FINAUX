using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Square
    {
        private List<Rank> ranks;
        private HeadWaiter headWaiter;
        private List<Waiter> waiters;


        public Square()
        {
            ranks.Add(new Rank());
            ranks.Add(new Rank());

            headWaiter = new HeadWaiter();
            waiters.Add(new Waiter());
            waiters.Add(new Waiter());
        }
    }
}
