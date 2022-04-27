using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Team08
{
    public partial class CheckWindows : Form
    {
        public CheckWindows()
        {
            InitializeComponent();
        }

        private void uxBack_Check_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartWindows start = new StartWindows(new Controller());
            start.ShowDialog();
            this.Close();
            
        }

        private void uxBooking_Click(object sender, EventArgs e)
        {





            //connect to sql server
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=localhost;Initial Catalog=Team08;Integrated Security=True";//?
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            


        }
    }
}
