using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public class Tickets
    {
        public RegularBusRoute regularBusRoute;
        public BusRoute busTour;

        public Tickets(RegularBusRoute regularBusRoute, int countOfTickets)
        {
            this.regularBusRoute = regularBusRoute;
            this.countOfTickets = countOfTickets;
        }

        public Tickets(BusRoute busTour, int countOfTickets)
        {
            this.busTour = busTour;
            this.countOfTickets = countOfTickets;
        }

        public Tickets()
        {
            busTour = new BusRoute();
            countOfTickets = 0;
        }
        public BusRoute busRoute;
        public int countOfTickets;
    }
}
