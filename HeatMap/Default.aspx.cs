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
        List<MapLocation> addresses;
        GeocodeClient geocodeClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            addresses = new List<MapLocation>();
            geocodeClient = new GeocodeClient();

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            MapLocation location = geocodeClient.GetMapLocation(new Address {
                Street = txt_AddressLine1.Text,
                Apt = txt_AddressLine2.Text,
                City = txt_City.Text,
                Region = txt_State.Text,
                PostalCode = txt_Zip.Text
            });
            Response.Write($"<script>alert('Lat: {location.longitude} Lon: {location.longitude}');</script>");
        }
    }
}