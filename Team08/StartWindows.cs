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
//using Timer = System.Windows.Forms.Timer;
//using Timer = System.Threading.Timer;

namespace Team08
{
    public partial class StartWindows : Form
    {

        //Timer t = new Timer();
        
        public StartWindows()
        {
            InitializeComponent();


        }

        private void uxCheck_Click(object sender, EventArgs e)
        {
            CheckWindows cw = new CheckWindows();
            cw.Show();
            this.Hide();
        }

       

        

        private void StartWindows_Load(object sender, EventArgs e)
        {
            uxTimer.Start();
        }

        private void uxTimer_Tick(object sender, EventArgs e)
        {
            uxlabel2.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second).ToString();
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
