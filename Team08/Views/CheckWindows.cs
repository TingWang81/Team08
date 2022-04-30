using System;
using System.Windows.Forms;
using Team08.Models;


namespace Team08
{
    public partial class CheckWindows : Form
    {
        private Flight flight;
        private string firstName;
        private string lastName;
        private string email;

        public CheckWindows(Flight f)
        {
            InitializeComponent();
            this.flight = f;
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
            string[] flightInfo = new string[5];
            flightInfo[0] = "FLIGHT INFO:";
            flightInfo[1] = "Flight " + this.flight.FlightID.ToString();
            flightInfo[2] = "Departing Planet " + this.flight.DeparturePlanetID + " at " + this.flight.DepartureDateTime;
            flightInfo[3] = "Arriving " + this.flight.DestinationPlanetName + " at " + this.flight.ArrivalDateTime;
            flightInfo[4] = "Ticket Price $" + this.flight.TicketPrice;

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

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes form and tells parent not to expect results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
