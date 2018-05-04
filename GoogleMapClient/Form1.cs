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
using Microsoft.VisualBasic.FileIO;
using Geocode;

namespace GoogleMapClient
{
    public partial class GoogleMapForm : Form
    {
        public GeocodeClient geocodeClient = new GeocodeClient("AIzaSyBZXux8AYiiw4qaRYM2ufhn6GtEWat4Lg4");

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
            //WriteHTML();
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
    }

}
