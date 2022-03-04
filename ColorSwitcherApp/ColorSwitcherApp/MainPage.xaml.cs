using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSwitcherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double red = redSlider.Value;
            double green = greenSlider.Value;
            double blue = blueSlider.Value;

            Color bgColor = new Color(red, green, blue);
            boxColor.BackgroundColor = bgColor;
            //string hex = ColorToHex(bgColor);
            string hex = bgColor.ToHex();
            lblDisplay.Text = $"#{hex.Substring(3, 6)}";
        }

        private string ColorToHex(Color color)
        {
            int alpha = (int)(color.A * 255);
            int red = (int)(color.R * 255);
            int green = (int)(color.G * 255);
            int blue = (int)(color.B * 255);

            return $"#{alpha:X2}{red:X2}{green:X2}{blue:X2}";
        }
    }
}
