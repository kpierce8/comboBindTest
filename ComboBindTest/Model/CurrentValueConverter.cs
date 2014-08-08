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
    class CurrentValueConverter :IValueConverter
    {

        public ControlTemplate ButtonControlTemplate1 { get; set; }
        public ControlTemplate ButtonControlTemplate2 { get; set; }
        
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {


         //  Window window = Window.GetWindow(parameter);
         //   var resourceName = String.Empty;
        
            bool setHighlight = (bool)value;

            if (setHighlight)
            {
                return ButtonControlTemplate1;
            }
            else
            {
               return ButtonControlTemplate2;
            }


           // return window.FindResource(resourceName) as DataTemplate;
          // return resourceName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
