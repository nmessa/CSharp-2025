﻿//Lab Exercise 5.23.2025 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 2 arrays to hold suit and face values
            string[] suits = new string[]{"clubs", "diamonds", "hearts", "spades"};
            string[] faces = new string[] {"two", "three", "four", "five", "six", "seven", "eight", 
                "nine", "ten", "jack", "queen", "king", "ace"};

            //Create other variables
            //Add code here


            //Build the deck of cards
            //Add code here


            //print the deck
            //Add code here


            //Shuffle the deck
            //Add code here


            //print the deck after shuffling
            //Add code here


            //Create and initialize game variables
            //Add code here


            //Start game loop
            while (keepGoing && (hands < 26))
            {
                //Add code here


                //Print each player's hand
                //Add code here


                //get face value for each card
                //Add code here



                //Test to see who won
                //Add code here

            

                //Print current score
                //Add code here


                //check for another round
                //Add code here


       
            }

            //Print results of game
            //Add code here


        }

        static void shuffle(string[] d)
        {
            //Add code here

        }

        static int findIndex(string[] arr, string find)
        {
            //Add code here

        }
    }
}
