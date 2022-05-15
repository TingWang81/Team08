using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Team08.Models;
using System.Windows.Forms;

namespace Team08
{
    public partial class BookingControl : UserControl
    {
        private Flight flight;
        private StaticOuterWindow baseWindow;
        private Controller controller;


        private string firstName;
        private string lastName;
        private string email;

        public BookingControl(Controller c, StaticOuterWindow baseWindow, Flight f)
        {
            InitializeComponent();
            this.controller = c;
            this.flight = f;
            this.baseWindow = baseWindow;

            updateInfoBox();
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// Displays basic flight info for employee to complete booking a flight.
        /// </summary>
        private void updateInfoBox()
        {
            ShipType st = this.controller.GetShipTypeByShipID(this.flight.ShipID);

            string[] flightInfo = new string[8];
            flightInfo[0] = "FLIGHT INFO:";
            flightInfo[1] = "Flight " + this.flight.FlightID.ToString();
            flightInfo[2] = "Departing Planet " + this.flight.DeparturePlanetID + " at " + this.flight.DepartureDateTime;
            flightInfo[3] = "";
            flightInfo[4] = "Ship Name: " + st.ShipName;
            flightInfo[5] = "Ship Type: " + st.Name;
            flightInfo[6] = "";
            flightInfo[7] = "Ticket Price $" + this.flight.TicketPrice;

            this.infoTBox.Lines = flightInfo;
        }

        /// <summary>
        /// Collects person info and tells parent form to expect results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookBtn_Click(object sender, EventArgs e)
        {
            this.FirstName = this.firstNameTBox.Text;
            this.LastName = this.lastNameTBox.Text;
            this.Email = this.emailTBox.Text;

            this.controller.BookFlight(FirstName, LastName, Email, this.flight);
            MessageBox.Show("Booking Completed");
        }

        /// <summary>
        /// Closes form and tells parent not to expect results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.baseWindow.ChangeBaseWindowDisplay(new FlightsControl(this.controller, this.baseWindow, this.flight.DestinationPlanetName));
        }

        /// <summary>
        /// Takes customer info and cancels flight if exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBookingBtn_Click(object sender, EventArgs e)
        {
            this.FirstName = this.firstNameTBox.Text;
            this.LastName = this.lastNameTBox.Text;
            this.Email = this.emailTBox.Text;

            this.controller.DeleteFlightPerson(FirstName, LastName, Email, this.flight);
            MessageBox.Show("Booking Canceled");
        }
    }
}
