using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConvertor
{
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private double Fahrenheit;
        private double Celsius;
        private double Kelvin;

        private double FahrenheitToCelsius
        {
            get { return (Fahrenheit - 32) * 5 / 9; }
            set { Fahrenheit = value; }
        }


        private double FahrenheitToKelvin
        {
            get { return (Fahrenheit - 32) * 5 / 9 + 273.15; }
            set { Fahrenheit = value; }
        }


        private double CelsiusToKelvin
        {
            get { return Celsius + 273.15; }
            set { Celsius = value; }
        }

        private double CelsiusToFahrenheit
        {
            get { return (Celsius * 9 / 5) + 32; }
            set { Celsius = value; }
        }


        private double KelvinToCelcius
        {
            get { return Kelvin - 273.15; }
            set { Kelvin = value; }
        }

        private double KelvinToFahrenheit
        {
            get { return (Kelvin - 273.15) * 9 / 5 + 32; }
            set { Kelvin = value; }
        }


        private void Convertor()
        {
            if (string.IsNullOrEmpty(txtTemp1.Text) || txtTemp1.Text == "-")
            {
                txtTemp2.Text = " ";
            }
            else if (cbTemperature.Text == "Celsius to Fahrenheit")
            {
                CelsiusToFahrenheit = Convert.ToDouble(txtTemp1.Text);
                txtTemp2.Text = CelsiusToFahrenheit.ToString();
            }
            else if (cbTemperature.Text == "Celsius to Kelvin")
            {
                CelsiusToKelvin = Convert.ToDouble(txtTemp1.Text);
                txtTemp2.Text = CelsiusToKelvin.ToString();
            }
            else if (cbTemperature.Text == "Fahrenheit to Celsius")
            {
                FahrenheitToCelsius = Convert.ToDouble(txtTemp1.Text);
                txtTemp2.Text = FahrenheitToCelsius.ToString();
            }
            else if (cbTemperature.Text == "Fahrenheit to Kelvin")
            {
                FahrenheitToKelvin = Convert.ToDouble(txtTemp1.Text);
                txtTemp2.Text = FahrenheitToKelvin.ToString();
            }
            else if (cbTemperature.Text == "Kelvin to Celsius")
            {
                KelvinToCelcius = Convert.ToDouble(txtTemp1.Text);
                txtTemp2.Text = KelvinToCelcius.ToString();
            }
            else if (cbTemperature.Text == "Kelvin to Fahrenheit")
            {
                KelvinToFahrenheit = Convert.ToDouble(txtTemp1.Text);
                txtTemp2.Text = KelvinToFahrenheit.ToString();
            }
        }




        private void Temperature_Load(object sender, EventArgs e)
        {
            cbTemperature.SelectedIndex = 0;
        }

        private void txtTemp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if ((key == 46 && txtTemp1.Text.IndexOf(".") != -1) ||
                (key == 45 && txtTemp1.Text.IndexOf(".") != -1) ||
                (key == 45 && txtTemp1.Text.IndexOf(".") != -1) ||
                 (!Char.IsDigit(key) && key != 8 && key != 46 && key != 45))
            {
                e.Handled = true;

                return;
            }
        }
        private void ChangeTempLabel1()
        {
            switch (cbTemperature.Text)
            {
                case "Celsius to Fahrenheit":
                    lblTemp1.Text = "Celsius";
                    lblTemp2.Text = "Fahrenheit";
                    txtFormula.Text = "(0°C x 9/5) + 32 = 32°F";
                    break;


                case "Celsius to Kelvin":
                    lblTemp1.Text = "Celsius";
                    lblTemp2.Text = "Kelvin";
                    txtFormula.Text = "0°C + 273.15 = 273.15K";
                    break;

                case "Fahrenheit to Celsius":
                    lblTemp1.Text = "Fahrenheit";
                    lblTemp2.Text = "Celsius";
                    txtFormula.Text = "(0°F - 32) x 5/9 = -17.78°C";
                    break;

                case "Fahrenheit to Kelvin":
                    lblTemp1.Text = "Fahrenheit";
                    lblTemp2.Text = "Kelvin";
                    txtFormula.Text = "(0°F - 32) x 5/9 = 255.372K";
                    break;

                case "Kelvin to Celsius":
                    lblTemp1.Text = "Kelvin";
                    lblTemp2.Text = "Celsius";
                    txtFormula.Text = "0K - 273.15 = -273.15°C";
                    break;

                case "Kelvin to Fahrenheit":
                    lblTemp1.Text = "Kelvin";
                    lblTemp2.Text = "Fahrenheit";
                    txtFormula.Text = "(0K - 273.15) X 9/5 + 32 = -459.7°F";
                    break;
            }
        }

        private void cbTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convertor();
            ChangeTempLabel1();

        }

        private void txtTemp1_TextChanged(object sender, EventArgs e)
        {
            Convertor();
        }
    }
}
