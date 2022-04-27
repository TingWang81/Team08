using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Team08.Models;
//using Timer = System.Windows.Forms.Timer;
//using Timer = System.Threading.Timer;

namespace Team08
{
    public partial class StartWindows : Form
    {
        private Controller controller;
        
        public StartWindows(Controller c)
        {
            InitializeComponent();
            this.controller = c;
            setupDestinationButtons();
            this.BackgroundImage = Properties.Resources.StartWinBackground;
        }

        private void uxCheck_Click(object sender, EventArgs e)
        {
            CheckWindows cw = new CheckWindows();
            cw.Show();
            this.Hide();
        }

        private void management_button_Click(object sender, EventArgs e)
        {
            var mang_window = new ManagementWindow(this.controller);
            mang_window.Show();
        }

        private void destination_Planet_Click(object sender, EventArgs e)
        {
            string planetName = ((Button)sender).Text;
            var bookingWindow = new backBtn(this.controller, planetName);
            bookingWindow.Show();
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
