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
    public partial class BoughtTicketsControl : UserControl
    {
        User _user;
        List<BusRoute> busTours;
        BusRoute busRoute;
        List<Tickets> tickets;
        Tickets ticket;
        const string nameOfFile = "Ticket.txt";
        public BoughtTicketsControl()
        {
            InitializeComponent();
            _user = new User();
            busTours = _user.LoadScheduleFromFile("NewFile.txt");
            tickets = _user.LoadTicketFromFile(nameOfFile);
            dataGridView1.DataSource = tickets;
        }
        public void InsertDataIntoDataGridView()
        {
            busTours = _user.LoadScheduleFromFile("NewFile.txt");
            dataGridView1.DataSource = tickets.Select(c => c.regularBusRoute).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var foundValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = foundValue;
            dataGridView2.AutoGenerateColumns = false;

            // Define the column for countOfSeats
            DataGridViewTextBoxColumn seatsColumn = new DataGridViewTextBoxColumn();
            seatsColumn.DataPropertyName = "countOfSeats";
            seatsColumn.HeaderText = "Count of Seats";
            dataGridView2.Columns.Add(seatsColumn);
            var countOfTickets = tickets.Where(c => c.regularBusRoute.DepartureTime.ToString() == foundValue).Select(g => g.countOfTickets);
            foreach (var count in countOfTickets)
            {
                dataGridView2.Rows[0].Cells[0].Value = count;
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            ticket = tickets.Find(c => c.regularBusRoute.DepartureTime.ToString() == textBox1.Text);
            foreach (var _ticket in tickets)
            {
                if (_ticket.regularBusRoute.RouteNumber == ticket.regularBusRoute.RouteNumber && _ticket.regularBusRoute.Destination == ticket.regularBusRoute.Destination && _ticket.regularBusRoute.StartRoute == ticket.regularBusRoute.StartRoute)
                {
                    tickets.Remove(_ticket);

                    break;
                }
            }

            foreach (var busTour in busTours)
            {
                if (busTour.RouteNumber == ticket.regularBusRoute.RouteNumber && busTour.Destination == ticket.regularBusRoute.Destination && busTour.StartRoute == ticket.regularBusRoute.StartRoute)
                {
                    busTour.AvailableSeats += 1;
                }
            }
            _user.routes = busTours;
            _user.tickets = tickets;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tickets;
            MessageBox.Show("You sold a ticket");
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            textBox1.Text = "";
            _user.SaveTicketsToFile("Ticket.txt");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            tickets = _user.LoadTicketFromFile(nameOfFile); 
            dataGridView1.DataSource = tickets.Select(c => c.regularBusRoute).ToList();
        }
    }
}
