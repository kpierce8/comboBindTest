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
    class CurrentLandClassStyleSelector : DataTemplateSelector
    {


        public CurrentLandClassStyleSelector()
        {

        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Button button = (Button)item;

            string myBind = button.CommandParameter.ToString();


            var resourceName = String.Empty;

            if (myBind.Equals("bob"))
            {
                 resourceName = "ButtonControlTemplate2";
            } else
	                {
                  resourceName = "ButtonControlTemplate1";
	                }

          
            var element = container as FrameworkElement;
            return element.FindResource(resourceName) as DataTemplate;
            
            
           
        }
       

    }
}
