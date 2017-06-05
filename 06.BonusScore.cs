using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BonusScore
{
    class Program
    {
        static void Main(string[] args)
         {
            int score = int.Parse(Console.ReadLine());
            double bonusScore = 0.0;
            double totalScore = 0.0;
            double addBonusScore = 0.0;


            if (score < 100)
            {
                bonusScore = 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonusScore = 0.2 * score;
            }
            else
            {
                bonusScore = 0.1 * score;
            }
            if (score % 2 == 0)
            {
                addBonusScore = 1;
            }
            else if (score % 5 == 0)
            {
                addBonusScore = 2;
            }

            Console.WriteLine(bonusScore + addBonusScore);
            Console.WriteLine(score + bonusScore + totalScore + addBonusScore);
            

            
        }
    }
}
