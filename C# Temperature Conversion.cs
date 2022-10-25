// Exercise 14.6 TemperatureForm.cs
// Converting temperatures from Fahrenheit to Celsius.
using System;
using System.Windows.Forms;

namespace Temperature
{
    public partial class TemperatureForm : Form
    {
        // constructor
        public TemperatureForm()
        {
            InitializeComponent();
        } // end constructor

        // event handler that converts temperature
        private void convertButton_Click(object sender, EventArgs e)
        {
            int fahrenheit;
            int celsius;

            fahrenheit = Convert.ToInt32(fahrenheitTextBox.Text);
            celsius = Convert.ToInt32(5.0 / 9.0 * (fahrenheit - 32));

            displayLabel.Text = fahrenheit +
               " degrees Fahrenheit is\n" + celsius + " degrees Celsius";
        } // end method convertButton_Click
    } // end class TemperatureForm
} // end namespace Temperature
