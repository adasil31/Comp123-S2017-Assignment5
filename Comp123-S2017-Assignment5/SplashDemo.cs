﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Student Name: Alessandro da Silva Santos
 * Student Number: 300927354
 * rename the Form name
 * Project 0.3 - Created a public property at BMICalculator.
 * August 14-2017
 * */

namespace Comp123_S2017_Assignment5
{
    public partial class SplashDemo : Form
        {
        //private instance variable 
        //Constructors 

        private BMICalculator _BMICalculator;
        //Public properties 
        public BMICalculator BMICalculator {

            get
            {
                return Program.BMICalculator;
            }

        }
         

        public SplashDemo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashDemo_Load(object sender, EventArgs e)
        {

        }

        private void SplashDemoTimer_Tick(object sender, EventArgs e)
        {

            this.BMICalculator.Show();

            this.Hide();
            SplashDemoTimer.Enabled = false; //turn time off.
        }
    }
}
