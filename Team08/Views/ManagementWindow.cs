using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Team08.Models;

namespace Team08
{
    public partial class ManagementWindow : Form
    {
        private Controller controller;
        public ManagementWindow(Controller c)
        {
            InitializeComponent();
            this.controller = c;
            this.BackgroundImage = Properties.Resources.ManagementWinPic;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custSearchBtn_Click(object sender, EventArgs e)
        {
            string[] fullName = this.custNameSearchBox.Text.Split(' ');
            Person p = this.controller.GetPerson(fullName[0], fullName[1]);
            groupBox1.Text = p.FirstName + " " + p.LastName + "\n" + p.EmailAddress +
                p.EmailAddress;
            //MessageBox.Show(
            //    p.FirstName + " " + p.LastName + "\n" +
            //    p.EmailAddress
            //    );
        }

        private void shipSearchBtn_Click(object sender, EventArgs e)
        {
            string shipName = this.shipSearchBox.Text;
            SpaceShip sp = this.controller.GetSpaceShip(shipName);
            groupBox1.Text = "The ShipId is " + sp.ShipID + " The ShipName is " + sp.ShipName + ". Also, ShipTypeID is " + sp.ShipTypeID;
            //MessageBox.Show(
            //    "The ShipId is " + sp.ShipID + " The ShipName is " + sp.ShipName + ". Also, ShipTypeID is "+ sp.ShipTypeID
            //    );
        }

        private void planetSearchBtn_Click(object sender, EventArgs e)
        {
            string planetName = this.planetNameSearchBox.Text;
            Planet pl = this.controller.GetPlanet(planetName);
            groupBox1.Text = "The Planet Id is " + pl.PlanetID + "." + " It named " + pl.PlanetName + "." +"\n" +"The mass is " + pl.Mass + "," + " and the radius is " + pl.Radius + ", " + "and the X coordinate is " + pl.XCoordinate + "." + "\n"
                + "The distance from earth is " + pl.DistanceFromEarth + "." + "The soloarSystemId is " + pl.SolarSystemID + ".";
            //MessageBox.Show(
            //    "The Planet Id is " + pl.PlanetID + "." + " It named " + pl.PlanetName + "." + "The mass is " + pl.Mass + "," + " and the radius is " + pl.Radius + ", " + "and the eclipticCoordinate is " +pl.EclipticCoordinate +"." + "\n"
            //    + "The distance from earth is " + pl.DistanceFromEarth + "." + "The soloarSystemId is " + pl.SolarSystemID + "."
            //    );
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

            foreach(Person p in persons){
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

            foreach(SpaceShip ss in spaceShips)
            {
                s = s + "\n" + ss.ShipName + " has carried " + ss.TotalNumPassengers + " passengers to date.\n";
            }

            MessageBox.Show(s, "Ranked Ships By Total Number Of Passengers");
        }
    }
}
