using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Pr32_ObserverPattern2_Torsdag_30_11_2023
{
    public interface ISubject
    {
        public void Attach(IObserver o);
        public void Detach(IObserver o);

        public void Notify();
    }
}
