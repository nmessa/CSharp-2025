//SpinCycle Windows Application
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
using Microsoft.VisualBasic;


namespace SpinCycle
{
    public partial class Form1 : Form
    {
        //Global variables
        int crankSprockets, wheelSprockets;
        double diameter;
        int rotations, gear;
        double distance = 0;
      
        public Form1()
        {
            InitializeComponent();
        }


        
        private void cboRG_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the number number of sprockets on the wheel
            //Add Code here


            //If all combo boxes populated enable the Add Gear Info Button
            //Add Code here

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string temp;
            if (radFront.Checked)   //Add gears (Tooth count) on crank
            {
                //Add Code here

            }

            if (radRear.Checked)  //Add gears (Tooth count) on wheel
            {
                //Add Code here

            }

            //If lstFront and lstRear populated disable the Add Gear Info button
            //and enable the Add cycle instruction button
            if (lstFront.Items.Count == crankSprockets && 
                lstRear.Items.Count == wheelSprockets)
            {
                //Add Code here

            }
        }

        private void cboDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get wheel diameter from combobox
            //Add Code here

        }

        private void cboFG_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the number of sprockets on crank from combobox
            //Add Code here

        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            //Get cycle instructions and place in lstProgram
            string temp;
            temp = Interaction.InputBox("Enter the gear number and number of turns",
                "Cycle Program", "", 10, 10);
            lstProgram.Items.Add(temp);
            btnCalculate.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using SpinCycle");
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset the program
            cboDiameter.Text = "";
            cboFG.Text = "";
            cboRG.Text = "";
            lstFront.Items.Clear();
            lstRear.Items.Clear();
            lstProgram.Items.Clear();
            radFront.Checked = true;
            radRear.Checked = false;
            btnAdd.Enabled = false;
            btnCalculate.Enabled = false;
            btnProgram.Enabled = false;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Create three Lsts for store crank and wheel gear data as gear ratios
            List<double> ratios = new List<double>();
            List<int> crankGears = new List<int>();
            List<int> wheelGears = new List<int>();

            //Store crankGears
            for (int i = 0; i < crankSprockets; i++)
            {
                //Add Code here

            }

            //Store wheelGears
            for (int i = 0; i < wheelSprockets; i++)
            {
                //Add Code here

            }

            //Calculate gear ratios
            for (int i = 0; i < crankGears.Count; i++)
            {
                for (int j = 0; j < wheelGears.Count; j++)
                {
                    //Add Code here
                }
            }

            //Sorts gear ratios
            //Add Code here

            //Print Gear Table
            string newline = Environment.NewLine;
            string message = "Gear" + "\t" + "Ratio" + newline;
            for (int i = 0; i <  crankSprockets * wheelSprockets; i++)
            {
                //Add Code here

            }
            MessageBox.Show(message);

            //Read in gear and rotation data
            string[] temp;
            for (int i = 0; i < lstProgram.Items.Count; i++)
            {
                //Add Code here

                //Calculate distance traveled
                //Add Code here

            }

            //Convert inches to feet
            //Add Code here

            //Output result to a label
            //Add Code here
        } 
    }
}
