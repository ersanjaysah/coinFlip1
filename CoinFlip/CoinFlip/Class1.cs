using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Class1
    {
        public static void flip(int tossnumber)
        {
            int Head = 0;
            int Tail = 1;
            Random obj = new Random();
            while (tossnumber > 1)
            {
                int randomCheck = obj.Next(0, 2);
                if (randomCheck == 0)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
                tossnumber--;
            }
            Console.WriteLine("Head= " + Head);
            Console.WriteLine("Tail= " + Tail);
        }
    }
}
