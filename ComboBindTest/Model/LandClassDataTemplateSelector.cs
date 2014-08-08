using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ComboBindTest.Model
{
    public class LandClassDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplateTree { get; set; }
        public DataTemplate DataTemplateUrban { get; set; }
        public DataTemplate DataTemplateGrass { get; set; }

        public override DataTemplate SelectTemplate(object item,
          DependencyObject container)
        {
            dataItem mItem = (dataItem)item;
            // String ext = System.IO.Path.GetExtension(path);
            switch (mItem.landCLass)
            {
                case 1:
                    return DataTemplateTree;
                case 2:
                    return DataTemplateUrban;
                case 3:
                    return DataTemplateGrass;
                default:
                    return DataTemplateTree;
            }

        }
    }
}
