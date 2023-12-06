using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr32_ObserverPattern2_Torsdag_30_11_2023
{
    public delegate void NotifyHandler();
    public class Academy : Organization
    {
        //private List<IObserver> students = new List<IObserver>();
        public NotifyHandler MessageChanged;

        private string message;
        public string Message 
        {
            get { return message; } 
            set { message = value; OnMessageChanged(); } 
        }

        public Academy (string name, string address) : base(name)
        {
            Address = address;
        }

        public void OnMessageChanged()
        {
            if (MessageChanged != null)
                MessageChanged();
        }
    }
}
