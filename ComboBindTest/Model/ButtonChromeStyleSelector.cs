using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ComboBindTest.Model
{
    class ButtonChromeStyleSelector: StyleSelector
    {

        public Style ButtonStyle1 { get; set; }
        public Style ButtonStyle2 { get; set; }

        public override Style SelectStyle(object item,
        DependencyObject container)
        {
            Style st = new Style();

            Button thisButton = (Button)item;

            int index2 = Int16.Parse((string)thisButton.Tag);
            int index = Int16.Parse((string)thisButton.CommandParameter);

           
            return ButtonStyle1;
        }
    }
}
