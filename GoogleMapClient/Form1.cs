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
                string[] values = line.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    //This will assign each value to some object that holds a lost of location fields
                    //values[0]; //Company Name
                    //values[1]; //Street Address
                    //values[2]; //Street Address 2
                    //values[3]; //City
                    //values[4]; //State
                    //values[5]; //ZipCode
                }
            }

            //using (StreamReader sr = new StreamReader(CSVTextBox.Text))
            //{
            //    string currentLine;
            //    // currentLine will be null when the StreamReader reaches the end of file
            //    while ((currentLine = sr.ReadLine()) != null)
            //    {
            //        //Submit address to Googles API 
            //        //Get long/lat
            //        //Add entry to the html file
            //        //Always save
            //    }
            //}





            //    TextFieldParser parser = new TextFieldParser(CSVTextBox.Text); //separate after each comma
            //    parser.TextFieldType = FieldType.Delimited;
            //    parser.SetDelimiters(","); //ignores commas

            //    string[] rows = parser.ReadFields();

            //    //Loop through data
            //    while (!parser.EndOfData) //while not at the of file
            //    {
            //        foreach (string row in rows)
            //        {
            //            try
            //            {

            //            }
            //            catch (Exception)
            //            {

            //                throw;
            //            }

            //        }
            //    }
        }
    }

}
