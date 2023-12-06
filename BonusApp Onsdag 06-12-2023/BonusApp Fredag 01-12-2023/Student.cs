using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr32_ObserverPattern2_Torsdag_30_11_2023
{
    public class Student : Person, IObserver
    {
        private Academy academy;
        private string message;
        public string Message { get { return message; } set { message = value; } }

        //private string name;
        //public string Name { get { return name; } }

        public Student (Academy academy, string name) : base (name) // Wants to use parent-constructor
        {
            this.academy = academy;
            academy.MessageChanged += Update;
        }

        public void Update ()
        {
            Message = academy.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {academy.Name}");
        }
    }
}
