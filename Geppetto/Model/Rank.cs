using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Rank
    {
        public List<Table> tables;

        public Rank(int rank)
        {
            tables = new List<Table>();


            switch (rank)
            {
                case 1:
                    tables.Add(new Table(92, 316, 4, 1));
                    tables.Add(new Table(220, 316, 4, 2));
                    tables.Add(new Table(348, 316, 4, 3));
                    tables.Add(new Table(476, 316, 4, 4));

                    tables.Add(new Table(92, 376, 6, 5));
                    tables.Add(new Table(220, 376, 6, 6));
                    tables.Add(new Table(348, 376, 6, 7));
                    tables.Add(new Table(444, 408, 2, 8));
                    tables.Add(new Table(508, 408, 2, 9));
                    break;
                case 2:
                    tables.Add(new Table(188, 536, 8, 10));
                    tables.Add(new Table(284, 504, 8, 11));
                    tables.Add(new Table(412, 504, 6, 12));
                    tables.Add(new Table(510, 536, 2, 13));

                    tables.Add(new Table(156, 662, 10, 14));
                    tables.Add(new Table(284, 662, 2, 15));
                    tables.Add(new Table(412, 630, 2, 16));
                    tables.Add(new Table(510, 630, 2, 17));

                    break;
                case 3:
                    tables.Add(new Table(128, 800, 4, 18));
                    tables.Add(new Table(256, 768, 2, 19));
                    tables.Add(new Table(256, 832, 2, 20));
                    tables.Add(new Table(384, 736, 6, 21));
                    tables.Add(new Table(510, 736, 6, 22));
                    tables.Add(new Table(992, 472, 10, 23));
                    break;
                case 4:
                    tables.Add(new Table(1090, 476, 8, 24));
                    tables.Add(new Table(1180, 440, 8, 25));
                    tables.Add(new Table(1340, 440, 8, 26));
                    tables.Add(new Table(1466, 440, 2, 27));
                    tables.Add(new Table(1466, 504, 2, 28));
                    tables.Add(new Table(832, 600, 4, 29));
                    tables.Add(new Table(958, 600, 4, 30));
                    tables.Add(new Table(1090, 600, 4, 31));
                    tables.Add(new Table(1342, 600, 4, 32));
                    tables.Add(new Table(1468, 600, 4, 33));
                    break;
                default:
                    break;
            }
        }
    }
}