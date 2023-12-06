using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr32_ObserverPattern2_Torsdag_30_11_2023
{
    public class Person
    {
        private string name;
        public string Name { get { return name; } }
        public Person (string name)
        {
            this.name = name;
        }
    }
}
