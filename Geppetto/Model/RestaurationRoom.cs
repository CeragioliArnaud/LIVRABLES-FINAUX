
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class RestaurationRoom
    {
        private List<Square> squares;
        private Butler butler;
        private Clerk clerk;
        public RestaurationRoom()
        {
            this.butler = new Butler(100,150);
            this.squares.Add(new Square());
            this.squares.Add(new Square());
            this.clerk = new Clerk(25, 125);
        }
    }
}
