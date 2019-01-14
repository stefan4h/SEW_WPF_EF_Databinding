using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Slider_Databinding_Example
{
    /// <summary>
    /// Interaktionslogik für ColourSlider.xaml
    /// </summary>
    public partial class ColourSlider : Window
    {
        public ColourSlider()
        {
            InitializeComponent();
            ValueChanged();
        }
        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ValueChanged();
        }

        private void ValueChanged()
        {
            Color color = Color.FromRgb((byte)slider_red.Value, (byte)slider_green.Value, (byte)slider_blue.Value);
            this.Background = new SolidColorBrush(color);
        }


    }
}
