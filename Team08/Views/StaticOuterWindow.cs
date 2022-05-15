using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team08
{
    public partial class StaticOuterWindow : Form
    {
        private Controller controller;

        public StaticOuterWindow(Controller c)
        {
            InitializeComponent();
            this.controller = c;

            DestinationPlanetControl sow = new DestinationPlanetControl(this.controller, this);
            this.Controls.Add(sow);
        }

        public void ChangeBaseWindowDisplay(UserControl uc)
        {
            this.Controls.RemoveAt(0);
            this.Controls.Add(uc);
        }
    }
}
