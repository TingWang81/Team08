using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team08.Models;

namespace Team08
{
    public partial class FlightsControl : UserControl
    {
        private Controller controller;
        private List<Flight> flights;
        private StaticOuterWindow baseWindow;
        private Dictionary<string, Flight> flightDict = new Dictionary<string, Flight>();

        public FlightsControl(Controller c, StaticOuterWindow sow, string planetName)
        {
            InitializeComponent();
            this.controller = c;
            this.flights = getFlights(planetName);
            this.baseWindow = sow;

            setupFlightButtons();
        }

        /// <summary>
        /// Gets available flights from database with specified destination planet.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="planetName"></param>
        /// <returns></returns>
        private List<Flight> getFlights(string planetName)
        {
            return this.controller.GetScheduledFlightsToPlanet("blah", planetName);
        }

        /// <summary>
        /// Creates layout and buttons for booking window. Each button represents an available scheduled flight.
        /// </summary>
        private void setupFlightButtons()
        {
            int buttonWidth = 1000;
            int x = 50;
            int y = 50;

            foreach (Flight flight in this.flights)
            {
                Button b = new Button();
                b.Name = flight.FlightID.ToString();
                b.Font = new Font(b.Font.FontFamily, 16);
                b.Width = 1000;
                b.Height = 60;
                b.Text = "Flight " + flight.FlightID + ":  " + "To " + flight.DestinationPlanetName + " Departing " + flight.DepartureDateTime;
                b.Padding = new Padding(10);
                b.Location = new Point(x, y);
                b.Click += schedule_flight_Click;

                x += buttonWidth + 50;

                if (this.Size.Width - x <= 0)
                {
                    x = 50;
                    y += 75;
                    b.Location = new Point(x, y);
                    x += buttonWidth + 50;
                }

                this.Controls.Add(b);
                this.flightDict.Add(b.Name, flight);
            }
        }

        /// <summary>
        /// Opens booking window and eigther gathers info about person paying for flight or returns empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void schedule_flight_Click(object sender, EventArgs e)
        {
            Flight f = this.flightDict[((Button)sender).Name];

            this.baseWindow.ChangeBaseWindowDisplay(new BookingControl(this.controller, this.baseWindow, f));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.baseWindow.ChangeBaseWindowDisplay(new DestinationPlanetControl(this.controller, this.baseWindow));
        }
    }
}
