using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int hCount = 0;
            int tCount = 0;
            Console.WriteLine("1.Toss coin");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");
            int option = Convert.ToInt16(Console.ReadLine());

            Boolean result;
            while (option == 1)
            {
                result = CoinFlip();
                if (result)
                {
                    hCount++;
                }
                else
                {
                    tCount++;
                }
                Console.WriteLine("Head: " + hCount + ", Tails: " + tCount + "\n");
                Console.WriteLine("1.Toss coin");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");
                option = Convert.ToInt16(Console.ReadLine());
            }
        }

        public static Boolean CoinFlip()
        {
            int coinFace;
            Random rand = new Random();
            coinFace = rand.Next(2);
            if (coinFace == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
    }
}

