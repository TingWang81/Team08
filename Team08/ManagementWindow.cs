using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team08.Models;

namespace Team08
{
    public partial class ManagementWindow : Form
    {
        private Controller controllerClass;
        public ManagementWindow(Controller c)
        {
            InitializeComponent();
            this.controllerClass = c;
            this.BackgroundImage = Properties.Resources.ManagementWinPic;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custSearchBtn_Click(object sender, EventArgs e)
        {
            string[] fullName = this.custNameSearchBox.Text.Split(' ');
            Person p = this.controllerClass.GetPerson(fullName[0], fullName[1]);
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
            SpaceShip sp = this.controllerClass.GetSpaceShip(shipName);
            groupBox1.Text = "The ShipId is " + sp.ShipID + " The ShipName is " + sp.ShipName + ". Also, ShipTypeID is " + sp.ShipTypeID;
            //MessageBox.Show(
            //    "The ShipId is " + sp.ShipID + " The ShipName is " + sp.ShipName + ". Also, ShipTypeID is "+ sp.ShipTypeID
            //    );
        }

        private void planetSearchBtn_Click(object sender, EventArgs e)
        {
            string planetName = this.planetNameSearchBox.Text;
            Planet pl = this.controllerClass.GetPlanet(planetName);
            groupBox1.Text = "The Planet Id is " + pl.PlanetID + "." + " It named " + pl.PlanetName + "." +"\n" +"The mass is " + pl.Mass + "," + " and the radius is " + pl.Radius + ", " + "and the eclipticCoordinate is " + pl.EclipticCoordinate + "." + "\n"
                + "The distance from earth is " + pl.DistanceFromEarth + "." + "The soloarSystemId is " + pl.SolarSystemID + ".";
            //MessageBox.Show(
            //    "The Planet Id is " + pl.PlanetID + "." + " It named " + pl.PlanetName + "." + "The mass is " + pl.Mass + "," + " and the radius is " + pl.Radius + ", " + "and the eclipticCoordinate is " +pl.EclipticCoordinate +"." + "\n"
            //    + "The distance from earth is " + pl.DistanceFromEarth + "." + "The soloarSystemId is " + pl.SolarSystemID + "."
            //    );
        }

        private void rankCustByDistanceBtn_Click(object sender, EventArgs e)
        {
            //List < Person > this.controllerClass
        }
    }
}
