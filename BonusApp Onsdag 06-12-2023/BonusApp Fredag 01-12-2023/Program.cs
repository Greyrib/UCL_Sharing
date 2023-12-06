using Pr32_ObserverPattern2_Torsdag_30_11_2023;

namespace BonusApp_Fredag_01_12_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Academy("UCL", "Seebladsgade");

            var s1 = new Student(p, "Jens");

            var s2 = new Student(p, "Niels");

            var s3 = new Student(p, "Susan");

            //p.Attach(s1);
            p.MessageChanged += s1.Update;

            //p.Attach(s2);
            p.MessageChanged += s2.Update;

            //p.Attach(s3);
            p.MessageChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            //p.Detach(s2);
            p.MessageChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            Console.ReadLine();
        }
    }
}