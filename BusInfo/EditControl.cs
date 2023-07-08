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
    public partial class EditControl : UserControl
    {
        User _user;
        List<BusRoute> busTours;
        BusRoute busRoute;
        const string nameOfFile = "NewFile.txt";
        public EditControl()
        {
            InitializeComponent();
            _user = new User();
            busTours = _user.LoadScheduleFromFile(nameOfFile);
            dataGridView1.DataSource = busTours;
        }
        public void InsertDataIntoDataGridView()
        {
            busTours = _user.LoadScheduleFromFile(nameOfFile);
            dataGridView1.DataSource = busTours;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            foreach (var busTour in busTours)
            {
                if (busTour.RouteNumber == busRoute.RouteNumber && busTour.Destination == busRoute.Destination && busTour.StartRoute == busRoute.StartRoute)
                {
                    busTour.RouteNumber = Convert.ToInt32(RouteNumberTextBox.Text);
                    busTour.StartRoute = StartRouteTextBox.Text;
                    busTour.Destination = DestinationTextBox.Text;
                    busTour.DepartureTime = Convert.ToDateTime(DepartureTimeTextBox.Text);
                    busTour.AvailableSeats = Convert.ToInt32(AvailableSeatsTextBox.Text);
                }
            }

            _user.routes = busTours;
            _user.SaveScheduleToFile(nameOfFile);
            busTours = _user.LoadScheduleFromFile(nameOfFile);
            dataGridView1.DataSource = busTours;
            EmptyPackageTextBox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _user.LoadScheduleFromFile(nameOfFile);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (var busTour in busTours)
            {
                if (busTour.RouteNumber == busRoute.RouteNumber && busTour.Destination == busRoute.Destination && busTour.StartRoute == busRoute.StartRoute)
                {
                    busTours.Remove(busTour);
                    break;
                }
            }

            _user.routes = busTours;
            _user.SaveScheduleToFile(nameOfFile);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _user.LoadScheduleFromFile(nameOfFile);
            EmptyPackageTextBox();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EmptyPackageTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var foundValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            busRoute = busTours.Find(c => c.DepartureTime.ToString() == foundValue);

            RouteNumberTextBox.Text = busRoute.RouteNumber.ToString();
            StartRouteTextBox.Text = busRoute.StartRoute.ToString();
            DestinationTextBox.Text = busRoute.Destination.ToString();
            DepartureTimeTextBox.Text = busRoute.DepartureTime.ToString();
            AvailableSeatsTextBox.Text = busRoute.AvailableSeats.ToString();
        }
        public void EmptyPackageTextBox()
        {
            RouteNumberTextBox.Text = "";
            StartRouteTextBox.Text = "";
            DestinationTextBox.Text = "";
            DepartureTimeTextBox.Text = "";
            AvailableSeatsTextBox.Text = "";
        }

    }
}
