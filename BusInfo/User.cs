using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public class User : FileOperation
    {
        public List<BusRoute> routes;
        public List<Tickets> tickets;

        public User()
        {
            routes = new List<BusRoute>();
            tickets = new List<Tickets>();
        }
        public User(List<BusRoute> routes, List<Tickets> tickets)
        {
            this.routes = routes;
            this.tickets = tickets;
        }

        // Додати рейс до розкладу
        public void AddRoute(BusRoute route)
        {
            routes.Add(route);
        }

        // Зберегти розклад у файл
        public override void SaveScheduleToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (BusRoute route in routes)
                {
                    writer.WriteLine($"{route.RouteNumber},{route.StartRoute},{route.Destination},{route.DepartureTime},{route.AvailableSeats}");
                }
            }
        }

        // Завантажити розклад з файлу
        public override List<BusRoute> LoadScheduleFromFile(string fileName)
        {
            routes.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    int routeNumber = int.Parse(data[0]);
                    string startRoute = data[1];
                    string destination = data[2];
                    DateTime departureTime = DateTime.Parse(data[3]);
                    int availableSeats = int.Parse(data[4]);

                    BusRoute route = new RegularBusRoute(routeNumber, startRoute, destination, departureTime, availableSeats);
                    AddRoute(route);
                }
            }

            return routes;
        }

        public List<Tickets> LoadTicketFromFile(string fileName)
        {
            routes.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    int routeNumber = int.Parse(data[0]);
                    string startRoute = data[1];
                    string destination = data[2];
                    DateTime departureTime = DateTime.Parse(data[3]);
                    int availableSeats = int.Parse(data[4]);
                    int countOfTickets = int.Parse(data[5]);

                    Tickets ticket = new Tickets(new RegularBusRoute(routeNumber, startRoute, destination, departureTime, availableSeats), countOfTickets);
                    tickets.Add(ticket);
                }
            }

            return tickets;
        }
        public void SaveTicketsToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Tickets ticket in tickets)
                {
                    writer.WriteLine($"{ticket.busTour.RouteNumber},{ticket.busTour.StartRoute},{ticket.busTour.Destination},{ticket.busTour.DepartureTime},{ticket.busTour.AvailableSeats},{ticket.countOfTickets}");
                }
            }
        }

    }
}
