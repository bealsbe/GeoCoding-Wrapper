using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geocode;

namespace GoogleMapWinForm
{
    public partial class Form1 : Form
    {
        public GeocodeClient geocodeClient;
        public List<MapLocation> addresses;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addresses = new List<MapLocation>();
            geocodeClient = new GeocodeClient("AIzaSyBZXux8AYiiw4qaRYM2ufhn6GtEWat4Lg4 ");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Stores MapLocation 
            MapLocation location = geocodeClient.GetMapLocation(new Address
            {
                Street = AddressLine1TextBox.Text,
                Apt = AddressLine2TextBox.Text,
                City = CityTextBox.Text,
                Region = StateTextBox.Text,
                PostalCode = ZipTextBox.Text
            });
            addresses.Add(location);

            //Gets the comp name from the textbox and adds it to the listbox
            LocationListBox.Items.Add((addresses.Count) + ": " + CompanyTextBox.Text);
        }
    }
}
