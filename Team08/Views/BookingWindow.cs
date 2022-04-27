using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team08.Models;

namespace Team08
{
    public partial class backBtn : Form
    {
        Controller controller;

        public backBtn(Controller c, string planetName)
        {
            InitializeComponent();
            this.controller = c;
            setupFlightButtons("blah", planetName);
        }

        /// <summary>
        /// Creates layout and buttons for booking window. Each button represents an available scheduled flight.
        /// </summary>
        private void setupFlightButtons(string solarSystem, string planetName)
        {
            List<Flight> flights = this.controller.GetScheduledFlightsToPlanet(solarSystem, planetName);

            int buttonWidth = 1000;
            int x = 50;
            int y = 50;

            foreach (Flight flight in flights)
            {
                Button b = new Button();
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
            }
        }

        private void schedule_flight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Works");
        }
    }
}
