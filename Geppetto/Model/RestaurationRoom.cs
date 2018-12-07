
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

        public RestaurationRoom()
        {
            this.butler = new Butler();
            this.squares.Add(new Square());
            this.squares.Add(new Square());
        }
    }
}
