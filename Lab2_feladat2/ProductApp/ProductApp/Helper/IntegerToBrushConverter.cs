using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;

namespace ProductApp.Helper
{
    [ValueConversion(typeof(string), typeof(Brushes))]

    
    public class IntegerToBrushConverter : IValueConverter
    {
        public static IntegerToBrushConverter integerToBrushConverter = new IntegerToBrushConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int quantity = (int)value;

            if (quantity <= 10000)
            {
                return Brushes.Red;
            }
            else
            {
                return Brushes.Blue;
            }
        }
        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
