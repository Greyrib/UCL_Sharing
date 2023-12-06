using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr32_ObserverPattern2_Torsdag_30_11_2023
{
    public class Organization
    {
        private string name;
        public string Name { get; }
        private string address;
        public string Address { get { return address; } set { address = value; } }

        public Organization (string name)
        {
            this.name = name;
        }

    }
}
