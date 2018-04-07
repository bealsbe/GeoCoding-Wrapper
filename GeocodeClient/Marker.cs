using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// This class will represent a marker on a Google Map
/// Read more about Markers in the Google Maps JS API:
/// https://developers.google.com/maps/documentation/javascript/examples/marker-simple
/// </summary>
namespace Geocode
{
    class Marker
    {
        private float _latitude;
        private float _longitude;

        public Marker(float lat, float longi)
        {
            _latitude = lat;
            _longitude = longi;
        }

    }
}
