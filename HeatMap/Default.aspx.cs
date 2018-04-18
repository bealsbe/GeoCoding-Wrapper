using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Geocode;

namespace HeatMap
{
    public partial class Default1 : System.Web.UI.Page
    {
        public List<MapLocation> addresses;
        public List<Marker> markers;
        GeocodeClient geocodeClient;


        protected void Page_Load(object sender, EventArgs e)
        {
            addresses = new List<MapLocation>();
            geocodeClient = new GeocodeClient();
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            //Gets the comp name from the textbox and adds it to the listbox
            CompanyListBox.Items.Add(CompanyName.Text);

            MapLocation location = geocodeClient.GetMapLocation(new Address {
                Street = txt_AddressLine1.Text,
                Apt = txt_AddressLine2.Text,
                City = txt_City.Text,
                Region = txt_State.Text,
                PostalCode = txt_Zip.Text
            });
            Response.Write($"<script>alert('Lat: {location.longitude} Lon: {location.longitude}');</script>");

            Clear_Fields();
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