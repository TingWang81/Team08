using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team08.Models;

namespace Team08.Views
{
    public partial class UpdatePersonControl : UserControl
    {
        private Controller controller;
        private Person person;
        private StaticOuterWindow baseWindow;

        public UpdatePersonControl(Controller c, Person p, StaticOuterWindow baseWindow)
        {
            InitializeComponent();
            this.controller = c;
            this.person = p;
            this.baseWindow = baseWindow;

            this.firstNameTxtBox.Text = p.FirstName;
            this.lastNameTxtBox.Text = p.LastName;
            this.emailTxtBox.Text = p.EmailAddress;
        }

        private void updatePersonBtn_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTxtBox.Text;
            string lastName = this.lastNameTxtBox.Text;
            string email = this.emailTxtBox.Text;

            this.controller.UpdatePerson(new Person(this.person.PersonID, firstName, lastName, email));
            this.baseWindow.ChangeBaseWindowDisplay(new ManagementControl(this.controller, this.baseWindow));
        }
    }
}
