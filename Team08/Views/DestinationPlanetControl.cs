using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Team08.Models;

namespace Team08
{
    public partial class DestinationPlanetControl : UserControl
    {
        private Controller controller;
        private StaticOuterWindow baseWindow;

        public DestinationPlanetControl(Controller c, StaticOuterWindow sow)
        {
            InitializeComponent();

            this.controller = c;
            this.baseWindow = sow;

            setupDestinationButtons();
            this.BackgroundImage = Properties.Resources.StartWinBackground;
        }

        /// <summary>
        /// Displays managers form inside of panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void management_button_Click(object sender, EventArgs e)
        {
            this.baseWindow.ChangeBaseWindowDisplay(new ManagementControl(this.controller, baseWindow));
        }

        private void destination_Planet_Click(object sender, EventArgs e)
        {
            string planetName = ((Button)sender).Text;
            baseWindow.ChangeBaseWindowDisplay(new FlightsControl(this.controller, this.baseWindow, planetName));
        }

        /// <summary>
        /// Creates layout and buttons for start screen. Each button represents a destination planet.
        /// </summary>
        private void setupDestinationButtons()
        {
            List<Planet> planets = this.controller.GetListOfPlanets();

            int buttonWidth = 175;
            int x = 50;
            int y = 50;

            foreach (Planet planet in planets)
            {
                Button b = new Button();
                b.Font = new Font(b.Font.FontFamily, 16);
                b.Width = 200;
                b.Height = 60;
                b.Text = planet.PlanetName;
                b.Padding = new Padding(10);
                b.Location = new Point(x, y);
                b.Click += destination_Planet_Click;

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

    }
}
