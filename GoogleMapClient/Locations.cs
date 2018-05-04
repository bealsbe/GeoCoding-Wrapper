using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapClient
{
    //Object that holds lists of location data
    class Locations
    {
        //List of strings that will hold values for each column in the CSV.
        public List<string> CompanyName = new List<String>();
        public List<string> StreetAddress = new List<String>();
        public List<string> SecondStreetAddress = new List<String>();
        public List<string> City = new List<String>();
        public List<string> State = new List<String>();
        public List<string> Zip = new List<String>();
    }
}
