using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Client
    {
        private int tableNumber { get; set; }
        private Boolean reserve { get; set; }
        private int addition { get; set; }
        private int numberClients { get; set; }

        public Client(Boolean reserve, int numberClients)
        {
            this.numberClients = numberClients;
            this.reserve = reserve;
            this.addition = 0;
        }
    }
}
