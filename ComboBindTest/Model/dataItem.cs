using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBindTest.Model
{
    public class dataItem
    {
       
        public string className { get; set; }

        public int landCLass { get; set; }

        public dataItem(int newvalue)
        {
            landCLass = newvalue;
        }

        public dataItem(int newvalue, string classn)
        {
            landCLass = newvalue;
            className = classn;
        }

      
    }
}
