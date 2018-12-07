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
        public Rank()
        {
            tables.Add(new Table(1, 1, 2));
            tables.Add(new Table(1, 2, 2));
            tables.Add(new Table(1, 3, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(2, 1, 10));
            tables.Add(new Table(2, 2, 4));
            tables.Add(new Table(2, 3, 2));
            tables.Add(new Table(2, 5, 4));

            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 2));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 10));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 2));

            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
            tables.Add(new Table(1, 5, 4));
        }
    }
}
