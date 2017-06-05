using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int sumSec = sec1 + sec2 + sec3;


        double min = sumSec / 60;
      double  sec = sumSec % 60;

            if (sec < 10)
            {
                Console.WriteLine("{0}:0{1}", min, sec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min, sec);
            }









        }
    }
}

            




        