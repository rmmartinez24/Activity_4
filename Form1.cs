using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SecondConverter_Click(object sender, EventArgs e)
        {
            double minutes;
            double hours;
            double days;
            double seconds;

            seconds = double.Parse(textBox1.Text);

            // Minutes
            if (seconds >= 60 && seconds <= 3600)
            {
                minutes = seconds / 60;

                textBox2.Text = minutes.ToString() + " Minutes";
            }

            // Hours
            else if (seconds >= 3600 && seconds <= 86400)
            {
                hours = seconds / 3600;

                textBox2.Text = hours.ToString() + " Hours";
            }

            // Days
            else if (seconds >= 86400)
            {
                days = seconds / 86400;

                textBox2.Text = days.ToString() + " Days";
            }

            // Seconds
            else if (seconds <= 59)
            {
                textBox2.Text = seconds.ToString() + " Seconds";
            }
        }
    }
}
