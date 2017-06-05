using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AreaofFigures
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
          
            if (figure == "square")
            {
                double size1 = double.Parse(Console.ReadLine());
                double squareArea = (size1 * size1);
                Console.WriteLine(squareArea);

            }
            else if (figure == "rectangle")
            {
                double size2 = double.Parse(Console.ReadLine());
                double size3 = double.Parse(Console.ReadLine());
                double rectangleArea = size2 * size3;
                Console.WriteLine(rectangleArea);
            }

            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * r * r;
                Console.WriteLine("{0:F3}", circleArea);

            }

            else if (figure == "triangle")
            {
                double size5 = double.Parse(Console.ReadLine());
                double size6 = double.Parse(Console.ReadLine());
                double triAngelArea = (size5 * size6)/2;
                Console.WriteLine(triAngelArea);
            }
            
                




        }
    }
}
