using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Flipcoin
    {
        public static void FliptheCoin()
        {
            int head = 0;
            int tail = 0;

            double headpercentage = 0.0;
            double tailpercentage = 0.0;

            Console.WriteLine("enter the number to flip the coin");
           
            int flip = Convert.ToInt32(Console.ReadLine());
            if (flip > 0)
            {
                
                for(int i = 0; i < flip; i++)
                {
                    Random random = new Random();
                    int num = random.Next(2);
                    Console.WriteLine("the random number is " + num);
                    if(num == 0)
                    {
                        Console.WriteLine("its a tail");
                        tail++;
                    }
                    else
                    {
                        Console.WriteLine("its a head");
                        head++;
                    }
                    

                }
                headpercentage = head * 100 / flip;
                tailpercentage = tail * 100 / flip;
                Console.WriteLine("total head % is " + headpercentage);
                Console.WriteLine("toatal tai % is " + tailpercentage);

            }
        }
    }
}
