using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Små_Metoder
{
    class Program
    {
        static int LægSammen(int a, int b)
        {
            return (a + b);
        }

        static double BeregnAreal(double radius)
        {
            double areal = radius * radius * System.Math.PI;
            return areal;            
        }

        static void udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static double gennemsnit(int[] månedsløn)
        {
            double snit = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                snit += månedsløn[i];
            }

            snit = snit / (månedsløn.Length);
            return snit;
        }

        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            udskriv("Dette er en test");
            int[] løn = { 10000, 5000, 30000 };
            double gns = gennemsnit(løn);
            Console.WriteLine(gns);
        }
    }

}
