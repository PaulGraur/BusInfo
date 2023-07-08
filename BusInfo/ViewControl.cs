using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusInfo
{
    public partial class ViewControl : UserControl
    {
        User _user;
        List<BusRoute> busTours;
        List<Tickets> boughtTickets;
        BusRoute busRoute;
        BusSchedule busSchedule;
        int countOfBoughtTickets;
        const string nameOfFile = "NewFile.txt";
        public ViewControl()
        {
            InitializeComponent();
            _user = new User();
            busTours = _user.LoadScheduleFromFile(nameOfFile);
            _user.routes = busTours;
            busSchedule = new BusSchedule();
            boughtTickets = new List<Tickets>();
            busSchedule.routes = busTours;
            dataGridView1.DataSource = busTours;
            countOfBoughtTickets = 0;
        }
        public void InsertDataIntoDataGridView()
        {
            busTours = _user.LoadScheduleFromFile(nameOfFile);
            dataGridView1.DataSource = busTours;
        }
        private void SortByTimeButton_Click(object sender, EventArgs e)
        {
            busTours = busSchedule.SortByTime();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = busTours;
        }

        private void SortByPlaceButton_Click(object sender, EventArgs e)
        {
            busTours = busSchedule.SortByDestination();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = busTours;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destination = NearestDestinationTextBox.Text;

            busRoute = busSchedule.FindNearestRoute(busTours, destination);

            dataGridView1.DataSource = null;
            busTours.Clear();
            busTours.Add(busRoute);
            dataGridView1.DataSource = busTours;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            busTours = _user.LoadScheduleFromFile(nameOfFile);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = busTours;
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            busRoute = busTours.Find(c => c.DepartureTime.ToString() == textBox1.Text);
            foreach (var busTour in busTours)
            {
                if (busTour.RouteNumber == busRoute.RouteNumber && busTour.Destination == busRoute.Destination && busTour.StartRoute == busRoute.StartRoute)
                {
                    if (busTour.AvailableSeats != 0)
                    {
                        busTour.AvailableSeats -= 1;
                        Tickets tickets = new Tickets(busTour, 1);
                        boughtTickets.Add(tickets);
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("You can't buy ticket, cause there are no place to seat");
                    }
                    break;
                }
            }
            _user.routes = busTours;
            _user.tickets = boughtTickets;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = busTours;
            if (flag)
                MessageBox.Show("You bought a ticket");
            _user.SaveTicketsToFile("Ticket.txt");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var foundValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = foundValue;
        }
    }
}
