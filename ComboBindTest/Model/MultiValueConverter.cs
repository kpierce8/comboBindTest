using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ComboBindTest.Model
{
    class MultiValueConverter :IMultiValueConverter
    {


        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var resourceName = String.Empty;
            //   TextBlock landClassTextBlock = (TextBlock)value;

            string currentLandClass = values[0].ToString();
            string buttonParam = values[1] as string;

            if (currentLandClass.Equals(buttonParam))
            {
                resourceName = "ButtonControlTemplate2";
            }
            else
            {
                resourceName = "ButtonControlTemplate1";
            }


            //return window.FindResource(resourceName) as DataTemplate;
            return resourceName;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
