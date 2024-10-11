using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissAdam1011._2._1
{
    internal class Program
    {
        static void napszak()
        {
            string reggel = "Jó reggelt kívánok";
            string delott = "Szép délelőttet kívánok";
            string del = "Kellemes delet kívánok";
            string dutan = "Szép délutánt kívánok";
            string este = "Kellemes estét";
            int ido = DateTime.Now.Hour;

            

            Console.WriteLine(DateTime.Now);

            if (ido > 0 && ido < 10) Console.WriteLine(reggel);
            if (ido > 10 && ido < 12) Console.WriteLine(delott);
            if (ido > 12 && ido < 13) Console.WriteLine(del);
            if (ido > 13 && ido < 18) Console.WriteLine(dutan);
            if (ido > 18 && ido < 24) Console.WriteLine(este);

        }
        

        static void Main(string[] args)
        {
            napszak();
        }
    }
}
