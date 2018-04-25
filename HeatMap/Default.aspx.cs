using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Geocode;

namespace HeatMap
{
    public partial class Default1 : System.Web.UI.Page
    {
        public List<MapLocation> addresses;
        GeocodeClient geocodeClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            addresses = new List<MapLocation>();
            geocodeClient = new GeocodeClient("AIzaSyCk9XYR_DLnFl6kzvnvoFw4lJTQ1Ejbqms");
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            //Gets the comp name from the textbox and adds it to the listbox
            CompanyListBox.Items.Add((addresses.Count+1) + ": " + CompanyName.Text);

            //Stores MapLocation 
            MapLocation location = geocodeClient.GetMapLocation(new Address {
                Street = txt_AddressLine1.Text,
                Apt = txt_AddressLine2.Text,
                City = txt_City.Text,
                Region = txt_State.Text,
                PostalCode = txt_Zip.Text
            });
            addresses.Add(location);

            Response.Write(@"
        <script>
            var map;
            function initMap()
            {
                map = new google.maps.Map(document.getElementById('map'), {
                zoom: 7.5,
                center: { lat: 44.942, lng: -122.933 }, //Oregon's coordinates (Willamette Valley)
                mapTypeId: 'roadmap' //map view vs. satellite view
            });

            "+ placeMarkers() + @"
            }

            function placeMarker(coordlat, coordlong)
            {
                var marker = new google.maps.Marker({
                position: { lat: coordlat, lng: coordlong },
                map: map
            });
        }

        </script>");

            Clear_Fields();
        }

        public string placeMarkers()
        {
            StringBuilder datastring = new StringBuilder();
            foreach(MapLocation address in addresses) {
                datastring.Append($"placeMarker({address.latitude},{address.longitude});\n");
            }
            return datastring.ToString();

        }

        /// <summary>
        /// This will clear any data entered into the textbox input fields,
        /// allowing the user to enter another location immediately
        /// </summary>
        private void Clear_Fields()
        {
            CompanyName.Text = null;
            txt_AddressLine1.Text = null;
            txt_AddressLine2.Text = null;
            txt_City.Text = null;
            txt_State.Text = null;
            txt_Zip.Text = null;
        }
    }
}