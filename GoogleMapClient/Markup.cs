using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geocode;

namespace GoogleMapClient
{
    class Markup
    {
        private StreamWriter _writer;

        public void Head(string path)
        {
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

            html.ForEach(_writer.WriteLine);
        }

        public void Tail(string path)
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

            html.ForEach(_writer.Write);
        }

        //Writes location data to the file
        public void WriteLocations(List<Tuple<string, MapLocation>> locationData)
        {
            for (int i = 0; i < locationData.Count; i++)
            {
                if (i ==  locationData.Count - 1)
                {
                    //last element, no ending comma
                    _writer.Write($"\n['{locationData[i].Item1}', {locationData[i].Item2.latitude}, {locationData[i].Item2.longitude}]");
                }
                else
                {
                    _writer.Write($"\n['{locationData[i].Item1}', {locationData[i].Item2.latitude}, {locationData[i].Item2.longitude},]");
                }
            }
        }    
    }
}
