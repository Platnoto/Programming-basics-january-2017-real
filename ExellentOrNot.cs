using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExcellentorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            double schoolGrate = double.Parse(Console.ReadLine());
            if ( schoolGrate >= 5.50 )
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
