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
    public partial class AddControl : UserControl
    {
        User _user;
        List<BusRoute> busTours;
        const string nameOfFile = "NewFile.txt";
        public AddControl()
        {
            InitializeComponent();
            _user = new User();
            _user.LoadScheduleFromFile(nameOfFile);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            BusRoute busRoute = new BusRoute()
            {
                RouteNumber = Convert.ToInt32(RouteNumberTextBox.Text),
                Destination = DestinationTextBox.Text,
                StartRoute = StartRouteTextBox.Text,
                DepartureTime = Convert.ToDateTime(DepartureTimeTextBox.Text),
                AvailableSeats = Convert.ToInt32(AvailableSeatsTextBox.Text)
            };

            _user.AddRoute(busRoute);

            _user.SaveScheduleToFile(nameOfFile);
            EmptyPackageTextBox();
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
