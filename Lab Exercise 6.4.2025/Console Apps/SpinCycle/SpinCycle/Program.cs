//Lab Exercise 6.4.2025 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SpinCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create lists to hold gear teeth values and gear ratios
            List<double> ratios = new List<double>();
            List<int> crankGears = new List<int>();
            List<int> wheelGears = new List<int>();

            //Create FileStream and StreamReader to read bicycle.txt
            FileStream fs = new FileStream("bicycle.txt", FileMode.Open, FileAccess.Read);
            StreamReader textfile = new StreamReader(fs);

            //Declare variables
            int crankSprockets, wheelSprockets;
            double diameter;
            string[] temp;
            double distance = 0.0;
            int rotations;
            int gear;

            //read first line and store the number of wheel and crank sprockets and diameter of wheel
            //Add code here


            //read second line and store the crank gear teeth values
            //Add code here


            //read third line and store wheel gear teeth values
            //Add code here


            //Calculate all gear ratios
            //Add code here


            //Sort the gear ratios for gears 1 to 10
            //Add code here

            //Print gear table
            //Add code here


            //Read in rotation and gear data
            while (true)
            {
                line = textfile.ReadLine();
                if (line == null) //stop loop when you run out of data
                    break;

                //break line into rotations and gear number
                //Add code here

                //Store number of rotations and which gear you are in
                //Add code here


                //Calculate distance traveled with this rotaton and gear data and add to distance
                //Be sure to multiply by PI to get the circumference of the wheel
                //Add code here

            }

            //Convert distance to feet
            //Add code here


            //Output the result
            Console.WriteLine("Distance traveled: " + Math.Round(distance,2) + " feet");
        }
    }
}
