using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Team08.Models;
using System.Windows.Forms;
using Team08.Views;

namespace Team08
{
    public partial class ManagementControl : UserControl
    {
        private Controller controller;
        private StaticOuterWindow baseWindow;

        public ManagementControl(Controller c, StaticOuterWindow sow)
        {
            InitializeComponent();

            this.controller = c;
            this.baseWindow = sow;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.baseWindow.ChangeBaseWindowDisplay(new DestinationPlanetControl(this.controller, this.baseWindow));
        }

        private void custSearchBtn_Click(object sender, EventArgs e)
        {
            string[] fullName = this.custNameSearchBox.Text.Split(' ');
            Person p = this.controller.GetPerson(fullName[1], fullName[0]);
            if (p != null)
            {
                List<FlightPerson> flightPersons = this.controller.GetBookedFlightsFromPerson(p.PersonID);

                string flights = "";
                foreach (FlightPerson fp in flightPersons)
                {
                    flights = flights + "\n     " + "Flight " + fp.FlightID;
                }

                groupBox1.Text = "First Name: " + p.FirstName + "\n" +
                    "Last Name: " + p.LastName + "\n" +
                    "Email: " + p.EmailAddress + "\n" +
                    "\nBooked Flights: " + flights;
            }
            else
            {
                groupBox1.Text = "No Such Person In Database";
            }
        }

        private void shipSearchBtn_Click(object sender, EventArgs e)
        {
            string shipName = this.shipSearchBox.Text;
            SpaceShip sp = this.controller.GetSpaceShip(shipName);
            ShipType st = this.controller.GetShipTypeByShipID(sp.ShipID);

            groupBox1.Text = "ShipID: " + sp.ShipID + "\n" +
                "ShipName: " + sp.ShipName + "\n" +
                "ShipType: " + st.Name;
            
        }

        private void planetSearchBtn_Click(object sender, EventArgs e)
        {
            string planetName = this.planetNameSearchBox.Text;
            Planet pl = this.controller.GetPlanet(planetName);
            groupBox1.Text = "Planet Id: " + pl.PlanetID + "\n" + 
                "Planet Name: " + pl.PlanetName + "\n" + 
                "Mass: " + pl.Mass + " units\n" + 
                "Radius: " + pl.Radius + " units\n" + 
                "Coordinates: " + pl.XCoordinate + "x : " + pl.SolarSystemID + "y";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rankCustByDistanceBtn_Click(object sender, EventArgs e)
        {
            List<Person> persons = this.controller.RankPersonsByDistance();

            string s = "";

            foreach (Person p in persons)
            {
                s = s + "\n" + p.FirstName + " " + p.LastName + "    <" + p.EmailAddress + ">    " + p.DistanceTravelled + "\n";
            }

            MessageBox.Show(s, "Loyal Customer Rank:");
        }

        /// <summary>
        /// Displays ranked spaceships by total number of passengers to date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rankShipCapacityBtn_Click(object sender, EventArgs e)
        {
            List<SpaceShip> spaceShips = this.controller.RankShipsByTotalNumPassengers();

            string s = "";

            foreach (SpaceShip ss in spaceShips)
            {
                s = s + "\n" + ss.ShipName + " has carried " + ss.TotalNumPassengers + " passengers to date.\n";
            }

            MessageBox.Show(s, "Ranked Ships By Total Number Of Passengers");
        }

        /// <summary>
        /// Updates person information 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatePersonBtn_Click(object sender, EventArgs e)
        {
            string[] fullName = this.custNameSearchBox.Text.Split(' ');
            Person p = this.controller.GetPerson(fullName[1], fullName[0]);
            if (p != null)
            {
                List<FlightPerson> flightPersons = this.controller.GetBookedFlightsFromPerson(p.PersonID);
                this.baseWindow.ChangeBaseWindowDisplay(new UpdatePersonControl(this.controller, p, this.baseWindow));
            }
            else
            {
                groupBox1.Text = "No Such Person In Database";
            }
        }
    }
}
