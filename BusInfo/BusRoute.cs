using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public class BusRoute
    {
        private int _routeNumber;
        private string _destination;
        private string _startRoute;
        private DateTime _departureTime;
        private int _availableSeats;

        public int RouteNumber
        {
            get { return _routeNumber; }
            set { _routeNumber = value; }
        }
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
        public string StartRoute
        {
            get { return _startRoute; }
            set { _startRoute = value; }
        }
        public DateTime DepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; }
        }
        public int AvailableSeats
        {
            get { return _availableSeats; }
            set { _availableSeats = value; }
        }
        public BusRoute()
        {
            _routeNumber = 0;
            _destination = null;
            _startRoute = null;
            _departureTime = default(DateTime);
            _availableSeats = 0;
        }
        public BusRoute(int routeNumber, string destination, string startRoute, DateTime departureTime, int availableSeats)
        {
            RouteNumber = routeNumber;
            Destination = destination;
            StartRoute = startRoute;
            DepartureTime = departureTime;
            AvailableSeats = availableSeats;
        }

        public virtual void PurchaseTicket()
        {

        }

        public override string ToString()
        {
            return $"Route: {RouteNumber}, Start route: {StartRoute}, Destination: {Destination},  Departure Time: {DepartureTime}, Available Seats: {AvailableSeats}";
        }
    }
}
