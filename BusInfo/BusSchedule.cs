using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public class BusSchedule : SortMethod
    {
        public List<BusRoute> routes;

        public BusSchedule()
        {
            routes = new List<BusRoute>();
        }

        public List<BusRoute> SortByTime()
        {
            routes.Sort((x, y) => DateTime.Compare(x.DepartureTime, y.DepartureTime));

            return routes;
        }

        // Сортувати розклад за місцем
        public List<BusRoute> SortByDestination()
        {
            routes.Sort((x, y) => x.Destination.CompareTo(y.Destination));

            return routes;
        }

        // Знайти найближчий рейс до заданого пункту
        public BusRoute FindNearestRoute(List<BusRoute> busTourList, string destination)
        {
            BusRoute nearestRoute = null;
            TimeSpan shortestTimeDifference = TimeSpan.MaxValue;
            DateTime currentTime = DateTime.Now;

            foreach (var route in busTourList)
            {
                if (route.DepartureTime >= currentTime && route.Destination == destination && route.AvailableSeats > 0)
                {
                    TimeSpan timeDifference = route.DepartureTime - currentTime;
                    if (timeDifference < shortestTimeDifference)
                    {
                        shortestTimeDifference = timeDifference;
                        nearestRoute = route;
                    }
                }
            }

            return nearestRoute;
        }
    }
}
