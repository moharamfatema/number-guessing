using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGuessing
{
    class Program
    {
        static int num;
        static bool win = false;
        static int guess(int num)
        {
            return num - Program.num;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            
            string guessStr, message;
            int guessNum, result, lo, hi;
            lo = 0;
            hi = 100;
            Program.num = r.Next(lo, hi);
            Console.WriteLine(format:"Guess a number between {0} and {1}:",lo, hi);

            do 
            {
                guessStr = Console.ReadLine();
                guessNum = int.Parse(guessStr);
                result = guess(guessNum);

                if(result == 0)
                {
                    win = true;
                    message = "You win!";
                }else if (result > 0)
                {
                    message = "Too high! Guess lower:";
                }
                else 
                {
                    message = "Too low! Guess higher:";
                }
                Console.WriteLine(message + "\n");
            }
            while (!win);
            Console.Write("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
