using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geocode;

namespace GoogleMapClient
{
    public partial class GoogleMapForm : Form
    {
        public GeocodeClient geocodeClient = new GeocodeClient("YOUR_API_KEY");

        //List of location data that stores a company name with its associated MapLocation objects
        public List<Tuple<string, MapLocation>> locationData = new List<Tuple<string, MapLocation>>();


        public GoogleMapForm()
        {
            InitializeComponent();
        }

        private void CSVButton_Click(object sender, EventArgs e)
        {
            OpenFile(CSVTextBox);
        }

        private void HTMLButton_Click(object sender, EventArgs e)
        {
            OpenFile(HTMLPathTextBox);
        }

        //Dialog for opening a file
        private void OpenFile(TextBox t)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.Stream myStream = null;
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            t.Text = ofd.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must select a file path" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WriteFileButton_Click(object sender, EventArgs e)
        {
            ReadCSV();
            StreamWriter sw = new StreamWriter(@HTMLPathTextBox.Text)
            {
                AutoFlush = true
            };

            //Methods that write parts of the html file
            Head(sw);
            WriteLocations(sw, locationData);
            Tail(sw);                      
        }

        //Read a csv file and gather data from each line to make a web-request to GoogleAPI
        private void ReadCSV()
        {
            //Loops through each line in the csv -  .Skip(1) ignores the first line(Headers)
            foreach (var line in File.ReadAllLines(CSVTextBox.Text, Encoding.GetEncoding(1250)).Skip(1))
            {
                //Each string in a row gets placed into this array
                string[] addressInfo = line.Split(',');

                //Assigns values to the MapLocation object from each string in the array
                MapLocation location = geocodeClient.GetMapLocation(new Address
                {
                    Street = addressInfo[1],
                    Apt = addressInfo[2],
                    City = addressInfo[3],
                    Region = addressInfo[4],
                    PostalCode = addressInfo[5]
                });
               
                //Adds the company name and MapLocation tied to it into the list
                locationData.Add(new Tuple<string, MapLocation>(addressInfo[0], location));
            }
        }

        public void Head(StreamWriter writer)
        {
            //StreamWriter _writer = new StreamWriter("test.html");
            List<string> html = new List<string>
            {
                "<!DOCTYPE html>",
                "<html>",
                "<head>",
                "  <meta http-equiv=\"content - type\" content=\"text/html; charset = UTF-8\" /> ",
                "  <title>Google Maps Multiple Markers</title>",
                "    <style>",
                "      html, body, #map {",
                "        height: 100%;",
                "        margin: 0px;",
                "        padding: 0px",
                "      }",
                "    </style>",
                "  <script src=\"http://maps.google.com/maps/api/js?sensor=false\" ",
                "          type=\"text/javascript\"></script>",
                "</head>",
                "<body>",
                "  <div id=\"map\"></div>",
                "",
                "  <script type=\"text/javascript\">",
                "    var locations = ["
            };

            html.ForEach(writer.WriteLine);
        }

        public void Tail(StreamWriter writer)
        {
            List<string> html = new List<string>
            {
                "    ];",
                " ",
                "    var map = new google.maps.Map(document.getElementById('map'), {",
                "      zoom: 10,",
                "      center: new google.maps.LatLng(45.527367, -122.660251),",
                "      mapTypeId: google.maps.MapTypeId.ROADMAP",
                "    });",
                "",
                "    var infowindow = new google.maps.InfoWindow();",
                "",
                "    var marker, i;",
                "",
                "    for (i = 0; i < locations.length; i++) { ",
                "      marker = new google.maps.Marker({",
                "        position: new google.maps.LatLng(locations[i][1], locations[i][2]),",
                "        map: map",
                "      });",
                "      google.maps.event.addListener(marker, 'click', (function(marker, i) {",
                "        return function() {",
                "          infowindow.setContent(locations[i][0]);",
                "          infowindow.open(map, marker);",
                "        }",
                "      })(marker, i));",
                "    }",
                "  </script>",
                "</body>",
                "</html>"
            };

            html.ForEach(writer.WriteLine);
        }

        //Writes location data to the file
        public void WriteLocations(StreamWriter writer, List<Tuple<string, MapLocation>> locationData)
        {
            for (int i = 0; i < locationData.Count; i++)
            {
                if (i == locationData.Count - 1)
                {
                    //last element, no ending comma
                    writer.Write($"      ['{locationData[i].Item1}', {locationData[i].Item2.latitude}, {locationData[i].Item2.longitude}]\n");
                }
                else
                {
                    writer.Write($"      ['{locationData[i].Item1}', {locationData[i].Item2.latitude}, {locationData[i].Item2.longitude}],\n");
                }
            }
        }
    }

}
