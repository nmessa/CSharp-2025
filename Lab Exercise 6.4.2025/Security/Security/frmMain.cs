//Airline Security System
//Author: 
//Date: 6.4.2025

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Security
{
    public partial class frmMain : Form
    {
        //Global static variables
        public static string first;
        public static string middle;
        public static string last;
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddPass_Click(object sender, EventArgs e)
        {
            //Create a FileStream to read passengers file
            //Add code here

            //Create a StreamWriter
            //Add code here

            string name;

            //Create and open passenger information form
            frmPass pass = new frmPass();
            pass.ShowDialog();

            //Create the name string
            //Add code here


            //Add passenger to passenger list box
            //Add code here


            //Write name to file
            //Add code here


            //close StreamWriter and FileStream
            //Add code here

        }

        private void btnAddLuggage_Click(object sender, EventArgs e)
        {
            //Create FileStream to read luggage data
            FileStream fs = new FileStream("luggage.txt", FileMode.Append, FileAccess.Write);
            
            //Create StreamWriter to write to luggage file
            StreamWriter writer = new StreamWriter(fs);


            string name;

            //Create and open luggage entry form
            frmLugg lugg = new frmLugg();
            lugg.ShowDialog();

            //Generate luggage name
            name = first + " " + middle + " " + last;

            //Add luggage name to luggage list
            lstLuggage.Items.Add(name);

            //Write luggage name to luggage file
            writer.WriteLine(name);

            //Close StreamWriter and FIleStream
            writer.Close();
            fs.Close();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            //Create a list of passengers
            List<string> passengers = new List<string>();
            string line;
            string message;

            //Create FileStream and StreamReader to read passengers.txt
            //Add code here


            //Prime the loop
            //Add code here


            //Read in passengers and add to passenger list
            while (line != null)
            {
                //Add code here

            }

            //Close StreamReader and FileStream
            //Add code here


            //Create FileStream and StreamReader for luggage file
            //Add code here


            //Prime the loop
            //Add code here


            //Check luggage has a passenger
            int count = 0;
            while (line != null)
            {
                if (passengers.Contains(line))
                {
                    //Safe Luggage
                    //Add code here

                }
                else
                {
                    //Unsafe luggage
                    //Add code here

                }
                //Read in next piece of luggage to check
                //Add code here

            }

            //Close StreamReader and FileStream
            //Add code here

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string line;

            //Create FileStream and StreamReader to read passengers.txt
            //Add code here


            //Prime the loop
            //Add code here


            //Read in passengers and add to list
            while (line != null)
            {
                //Add code here

            }

            //Close StreamReader and FileStream
            //Add code here


            //Create FileStream and StreamReader for luggage file
            //Add code here


            //Prime the loop
            //Add code here


            //Check luggage has a passenger
            while (line != null)
            {
                //Add code here

            }

            //Close StreamReader and FileStream
            //Add code here

        }
    }
}
