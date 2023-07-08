using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public class RegularBusRoute : BusRoute
    {
        public RegularBusRoute(int routeNumber, string destination, string startRoute, DateTime departureTime, int availableSeats)
            : base(routeNumber, destination, startRoute, departureTime, availableSeats)
        {
        }

        // Реалізація методу оформлення квитка
        public override void PurchaseTicket()
        {
            if (AvailableSeats > 0)
            {
                AvailableSeats--;
            }
            else
            {
                MessageBox.Show("No available seats on this route.");
            }
        }
    }
}
