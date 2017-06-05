using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TimeaAnd15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // var hours = int.Parse(Console.ReadLine());
            //  var minutes = int.Parse(Console.ReadLine());
            // DateTime time = new DateTime();
            // time = time.AddHours(hours);
            // time = time.AddMinutes(minutes + 15);
            //  Console.WriteLine(time.ToString("H:mm")):

            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            DateTime time = new DateTime();
            time = time.AddHours(hours);
            time = time.AddMinutes(minutes + 15);
            Console.WriteLine(time.ToString("H:mm"));



        }
    }
}
