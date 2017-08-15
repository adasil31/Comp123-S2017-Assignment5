using System;
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
 * Description: 0.5 -  handedly event to form closing
 * August 14-2017
 * */

namespace Comp123_S2017_Assignment5
{
    public partial class BMICalculator : Form
    {
        string radio;
        /// <summary>
        /// In this space is create the constructor of the BMI Calculator
        /// </summary>

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WeightBox.Text = "";
            HeightTextBox.Text = "";
            ResultTextBox.Text = "";
            YouareTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double weight = Convert.ToDouble(WeightBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double BMI = 0;

            if (radio == "Metric")
            {
                //Calculate the metric system //
                BMI = (height * height) / weight;
            }
            else if (radio == "Imperial")
            {
                //calculate imperial system //
                BMI = (weight * 703) / (height * height);
            }

            ResultTextBox.Text = Convert.ToString(BMI);

            if (BMI > 18.5)
            {
                YouareTextBox.Text = "Underweight";
            }
            else if (BMI > 24.9)
            {
                YouareTextBox.Text = "Normal";
            }

            if(BMI > 29.9)
            {
                YouareTextBox.Text = "Overweight";
            }
            else if (BMI > 30)
            {
                YouareTextBox.Text = "Obese";
            }

        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.radio = "Metric";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.radio = "Imperial";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        /// <summary>
        /// This is the handedly event to form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
