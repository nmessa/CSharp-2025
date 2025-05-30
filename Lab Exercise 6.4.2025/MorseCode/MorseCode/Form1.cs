//Morse Code Generator
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

namespace MorseCode
{
    public partial class Form1 : Form
    {
        //Create an array with all of the Morse codes for the letters A to Z
        string[] codes = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.","....", "..", ".---",
                                 "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...",
                                 "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
        string phrase;
        string morse = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Convert phrase to upper case
            phrase = txtInput.Text.ToUpper();

            for (int i = 0; i < phrase.Length; i++)
            {
                //Encode letters
                if (Char.IsLetter(phrase[i]))  
                {
                    //Add Code here
                }
                //encode punctuations
                else 
                {
                    //Add code here

                }
                //Add a space to morse
                //Add code here

            }

            //Output morse string to lblMorse
            //Add code here

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblMorse.Text = "";
            txtInput.Text = "";
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
