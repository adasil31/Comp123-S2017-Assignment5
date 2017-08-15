using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Student Name: Alessandro da Silva Santos
 * Student Number: 300927354
 * rename the Form name
 * Project 0.2 - Created a instance of the BMICalculator object
 * August 14-2017
 * */
namespace Comp123_S2017_Assignment5
{
    public static class Program
    {
        //created reference to forms.

        public static BMICalculator BMICalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instantiate a new object of type BMICalculator
            BMICalculator = new BMICalculator();
            Application.Run(new SplashDemo());

       }
    }
}
