using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp_Fredag_01_12_2023
{
    public class Product
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private double _value;
        public double Value { get { return _value; } set { _value = value; } }
    }
}
