using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace RadioButtonCheckBox_Example
{
    public class EnumBooleanConverter : IValueConverter
    {
        /*
        *value -> Selection from RadioButtonCheckBoxVM  
        *parameter -> ConverterParameter (in the radiobuttons)
        *targetType -> type of the target property (not important for this example)
        *culture -> important for culture dependent conversions (not important for this example)
        */
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //checks if Selection from RadioButtonCheckBoxVM has the same value as the ConverterParameter. Returns true or false
            return ((Enum)value).HasFlag((Enum)parameter);
        }
        /*
        *value -> IsChecked from radiobutton (true/false) 
        *parameter -> ConverterParameter (in the radiobuttons)
        *targetType -> type of the target property (not important for this example)
        *culture -> important for culture dependent conversions (not important for this example)
        */
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        { 
            //If the radiobutton is checked, it returns the ConverterParameter
            return value.Equals(true) ? parameter : Binding.DoNothing;
        }
    }
}
