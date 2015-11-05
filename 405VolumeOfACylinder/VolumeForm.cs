/*
 * Created by: Nicholas Ellul
 * Created on: 05-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-05
 * This program calculates the volume of a cylinder.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405VolumeOfACylinder
{
    public partial class frmVolume : Form
    {

        public double VolumeOfCylinder(double theRadius, double theHeight)
        {
            // This calculates the volume of a cylinder
            double theVolume;

            theVolume = Math.PI * Math.Pow(theRadius,2) * theHeight;
            theVolume = Math.Round(theVolume, 2);

            return theVolume;
        }

        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables

            double height;
            double radius;
            double volume;
            string volumeAsString;

            radius = Convert.ToDouble(this.nudRadius.Value);
            height = Convert.ToDouble(this.nudHeight.Value);

            //process

            volume = VolumeOfCylinder(radius, height);

            //output

            volumeAsString = Convert.ToString(volume);
            this.txtVolume.Text = volumeAsString;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
