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
            //PUT YOUR GOOGLE MAPS API KEY HERE
            geocodeClient = new GeocodeClient("API_KEY_HERE");
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

            /* ONLY FOR TESTING*/
            /* Remove for 'final' product */
            //Prints the latitude and longitude from the location
            MessageBox.Show($"Lat: {location.latitude} Long: {location.longitude} ");
        }
    }
}
