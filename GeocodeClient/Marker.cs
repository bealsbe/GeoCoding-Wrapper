using System;
using System.Collections.Generic;
using System.Text;

namespace Geocode
{
    class Marker
    {
          private float _latitude;
          private float _longitude;

          public Marker(float lat, float lng)
          {
               _latitude = lat;
               _longitude = lng;
          }

          public string LatLng()
          {
               return "{lat: }" + _latitude.ToString() + " lng: " + _longitude.ToString() + "};";
          }
     }
}
