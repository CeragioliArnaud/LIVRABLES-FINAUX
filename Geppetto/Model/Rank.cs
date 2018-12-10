using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Rank
    {
        private List<Table> tables;
        public Rank(int rank)
        {
            switch (rank)
            {
                case 1:
                    this.tables = new List<Table>
                    {
                        new Table(92, 316, 4),
                        new Table(220, 316, 4),
                        new Table(248, 316, 4),
                        new Table(476, 316, 4),

                        new Table(92, 376, 6),
                        new Table(220, 376, 6),
                        new Table(348, 376, 6),

                        new Table(444, 408, 2),
                        new Table(508, 408, 2)
                    };
                    break;
                case 2:
                    this.tables = new List<Table>
                    {
                        new Table(2, 1, 2),
                        new Table(2, 2, 2),
                        new Table(2, 3, 4),
                        new Table(2, 4, 4)
                    };
                    break;
                case 3:
                    this.tables = new List<Table>
                    {
                        new Table(3, 1, 2),
                        new Table(3, 2, 2),
                        new Table(3, 3, 4),
                        new Table(3, 4, 4)
                    };
                    break;
                default:
                    this.tables = new List<Table>
                    {
                        new Table(4, 1, 2),
                        new Table(4, 2, 2),
                        new Table(4, 3, 4),
                        new Table(4, 4, 4)
                    };
                    break;
            }
        }
    }
}
