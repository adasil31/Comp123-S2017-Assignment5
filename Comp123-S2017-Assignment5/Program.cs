﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Student Name: Alessandro da Silva Santos
 * Student Number: 300927354
 * rename the Form name
 * Project 0.4 - Include calculate BMI
 * August 14-2017
 * */
namespace Comp123_S2017_Assignment5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
