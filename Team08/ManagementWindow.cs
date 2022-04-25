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
        private Controller controller;
        public ManagementWindow(Controller c)
        {
            InitializeComponent();
            this.controller = c;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custSearchBtn_Click(object sender, EventArgs e)
        {
            string[] fullName = this.custNameSearchBox.Text.Split(' ');
            Person p = this.controller.GetPerson(fullName[0], fullName[1]);
            MessageBox.Show(
                p.FirstName + " " + p.LastName + "\n" +
                p.EmailAddress);
        }

        private void rankCustByDistanceBtn_Click(object sender, EventArgs e)
        {
            //List < Person > this.controllerClass
        }
    }
}
